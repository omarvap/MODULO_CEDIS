using conexionBD;
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
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNomcar.Text == string.Empty && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomcar, "Ingrese un nombre a la categoria");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }


            cargo nuevo = new cargo();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);


            nuevo.id = codigo;
            nuevo.Nombre_car = txtNomcar.Text;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;


            cn.cargo.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del cargo se registraron corectamente");
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
            if (this.txtId.Text == string.Empty && this.txtNomcar.Text == string.Empty && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomcar, "Ingrese un nombre a la categoria");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Seleccion de la tabla a actualizar.
            var datos = from car in cn.cargo
                        where car.id.ToString() == txtId.Text
                        select car;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                cargo encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Nombre_car = txtNomcar.Text;
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
                    MessageBox.Show("Los datos del cargo se Actualizaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Actualizaron");
            }

            Refresh();
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtNomcar.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
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
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from car in files.cargo
                               select new
                               {
                                   Codigo = car.id,
                                   Nombre = car.Nombre_car,
                                   Estado = car.Estado,
                                   Descripcion = car.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
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
            var datos = from b in buscar.cargo
                        where b.Nombre_car == txtBuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                cargo encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_car + " ");
                txtId.Text = Convert.ToString(encontrado.id);
                txtNomcar.Text = encontrado.Nombre_car;
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
                var datos = from b in buscar.cargo
                            where b.Nombre_car == txtBuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    cargo encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_car + " ");
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtNomcar.Text = encontrado.Nombre_car;
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
