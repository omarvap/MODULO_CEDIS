using conexionBD;
using conexionBD.VistasModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODULO_CEDIS
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }


        CEDISEntities cn = new CEDISEntities();

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            //Para cargar con el fromulario los datos
            cargarpersona();
            Refresh();
        }
        public void cargarpersona()
        {
            //Carga de datos para agregar el codigo de la persona que es una tabla relacionada
            using (CEDISEntities cn = new CEDISEntities())
            {
               var lstPersona = (from p in cn.persona
                              select p).ToList();

                cmbPersona.DataSource = lstPersona;
                cmbPersona.ValueMember = "id";
                cmbPersona.DisplayMember = "Nombre";

                if (cmbPersona == null)
                {
                    throw new ArgumentNullException(nameof(cmbPersona));
                }

            }
            
        }
        public override void Refresh()
        {
            //vista de los datos almacenados en la base de datos
            using (var files = new CEDISEntities())
            {
                var ViewData = from em in files.empleado
                               join per in files.persona on em.id_per equals per.id
                               select new
                               {
                                   Codigo = em.id,
                                   Codigo_persona = em.id_per,
                                   Nombre = per.Nombre,
                                   INSS = em.No_INSS,
                                   Estado = em.Estado,
                                   Descripcion = em.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();

            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //Validacion para no ingresar datos nulos
            if (this.txtId.Text == string.Empty && this.txtInss.Text == string.Empty 
                && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtInss, "Ingrese un nuemro de INSS");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            //Llamado de la tabla de la base de datos
            empleado nuevo = new empleado();
            //Insercion de los elementos a la base
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            nuevo.id = codigo;
            nuevo.id_per = Convert.ToInt32(cmbPersona.SelectedValue.ToString());
            nuevo.No_INSS = txtInss.Text;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;

            cn.empleado.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del empleado se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
            Refresh();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //validacion de datos nulos
            if (this.txtId.Text == string.Empty && this.txtInss.Text == string.Empty
                && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtInss, "Ingrese un nuemro de INSS");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            var datos = from empleado in cn.empleado
                        where empleado.id.ToString() == txtId.Text
                        select empleado;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                empleado encontrado = datos.First();
                //Actualizacion de los elementos de la base de datos
                int codigo = 0;
                int.TryParse(txtId.Text, out codigo);

                encontrado.id = codigo;
                encontrado.id_per = Convert.ToInt32(cmbPersona.SelectedValue.ToString());
                encontrado.No_INSS = txtInss.Text;
                encontrado.Estado = cmbEstado.Text;
                encontrado.Descripcion = txtDescripcion.Text;
            }
            else//En caso de no encontrar los dato mandamos el msj.
            {
                MessageBox.Show("No se en contro el dato buscado");
            }

            //validacion de la actualizacion
            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del empleado se Actualizaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Actualizaron");
            }

            Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //validacion si no a guardato los datos.
            if (txtId.Text != "" || cmbPersona.Text != "" || txtInss.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
            {

                if (MessageBox.Show("¿Tiene datos sin guardar, desea salir?", "Advertencia",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                Close();
            }
        }

        private void btnCerrarVista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion del boton de busqueda de datos.
            CEDISEntities buscar = new CEDISEntities();
            //Seleccion de los datos a buscar
            var datos = from b in buscar.empleado
                        join per in buscar.persona on b.id_per equals per.id
                        where per.Nombre == txtBuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                empleado encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.persona.Nombre+ " " );
                txtId.Text = Convert.ToString(encontrado.id);
                cmbPersona.Text = Convert.ToString(encontrado.id_per);
                txtInss.Text = encontrado.No_INSS;
                cmbEstado.Text = encontrado.Estado;
                txtDescripcion.Text = encontrado.Descripcion;
                txtBuscar.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El sugeto no existe");
            }
            
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                //Validacion del boton de busqueda de datos.
                CEDISEntities buscar = new CEDISEntities();
                //Seleccion de los datos a buscar
                var datos = from b in buscar.empleado
                            join per in buscar.persona on b.id_per equals per.id
                            where per.Nombre == txtBuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    empleado encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.persona.Nombre + " ");
                    txtId.Text = Convert.ToString(encontrado.id);
                    cmbPersona.Text = Convert.ToString(encontrado.id_per);
                    txtInss.Text = encontrado.No_INSS;
                    cmbEstado.Text = encontrado.Estado;
                    txtDescripcion.Text = encontrado.Descripcion;
                    txtBuscar.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El sugeto no existe");
                }
            }
        }
    }
}
