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
    public partial class FrmCEDIS : Form
    {
        public FrmCEDIS()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void FrmCEDIS_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNombreCEDIS.Text == string.Empty && this.txtDireccionCEDIS.Text == string.Empty
                && this.txtTelefonoCEDIS.Text == string.Empty && this.cmbEstado.Text == string.Empty && this.txtDescripcionCEDIS.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombreCEDIS, "Ingrese un nuemro de INSS");
                erroricono.SetError(txtDireccionCEDIS, "Ingrese una dirección");
                erroricono.SetError(txtTelefonoCEDIS, "Ingrese un numero de telefono");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
                erroricono.SetError(txtDescripcionCEDIS, "Ingrese una Descripción");
            }

            CEDIS nuevo = new CEDIS();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            int telefono = 0;
            int.TryParse(txtTelefonoCEDIS.Text, out telefono);

            nuevo.id = codigo;
            nuevo.Nombre_CEDIS = txtNombreCEDIS.Text;
            nuevo.Direccion_CEDIS = txtDireccionCEDIS.Text;
            nuevo.Telefono_CEDIS = telefono;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcionCEDIS.Text;


            cn.CEDIS.Add(nuevo);
            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos de la bodega se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtNombreCEDIS.Text != "" || txtDireccionCEDIS.Text != "" ||
               txtTelefonoCEDIS.Text != "" || cmbEstado.Text != "" || txtDescripcionCEDIS.Text != "")
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
                var ViewData = from ce in files.CEDIS
                               select new
                               {
                                   Codigo = ce.id,
                                   Nombre = ce.Nombre_CEDIS,
                                   Dirección = ce.Direccion_CEDIS,
                                   Telefono = ce.Telefono_CEDIS,
                                   Estado = ce.Estado,
                                   Descripción = ce.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }

        }
        private void btnCerrarVista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNombreCEDIS.Text == string.Empty && this.txtDireccionCEDIS.Text == string.Empty
                && this.txtTelefonoCEDIS.Text == string.Empty && this.cmbEstado.Text == string.Empty && this.txtDescripcionCEDIS.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombreCEDIS, "Ingrese un nuemro de INSS");
                erroricono.SetError(txtDireccionCEDIS, "Ingrese una dirección");
                erroricono.SetError(txtTelefonoCEDIS, "Ingrese un numero de telefono");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
                erroricono.SetError(txtDescripcionCEDIS, "Ingrese una Descripción");
            }

            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo para ingresar datos de tipo int.
            int telefono = 0;
            int.TryParse(txtTelefonoCEDIS.Text, out telefono);
            //Seleccion de la tabla a actualizar.
            var datos = from cd in cn.CEDIS
                        where cd.id.ToString() == txtId.Text
                        select cd;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                CEDIS encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Nombre_CEDIS = txtNombreCEDIS.Text;
                encontrado.Direccion_CEDIS = txtDireccionCEDIS.Text;
                encontrado.Telefono_CEDIS = telefono;
                encontrado.Estado = cmbEstado.Text;
                encontrado.Descripcion = txtDescripcionCEDIS.Text;
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
                    MessageBox.Show("Los datos de la bodega se Actualizaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Actualizaron");
            }

            Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion del boton de busqueda de datos.
            CEDISEntities buscar = new CEDISEntities();
            //Seleccion de los datos a buscar
            var datos = from b in buscar.CEDIS
                        where b.Nombre_CEDIS == txtBuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                CEDIS encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_CEDIS + " " + encontrado.Direccion_CEDIS);
                txtId.Text = Convert.ToString(encontrado.id);
                txtNombreCEDIS.Text = encontrado.Nombre_CEDIS;
                txtDireccionCEDIS.Text = encontrado.Direccion_CEDIS;
                txtTelefonoCEDIS.Text = Convert.ToString(encontrado.Telefono_CEDIS);
                cmbEstado.Text = encontrado.Estado;
                txtDescripcionCEDIS.Text = encontrado.Descripcion;
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
                var datos = from b in buscar.CEDIS
                            where b.Nombre_CEDIS == txtBuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    CEDIS encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_CEDIS + " " + encontrado.Direccion_CEDIS);
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtNombreCEDIS.Text = encontrado.Nombre_CEDIS;
                    txtDireccionCEDIS.Text = encontrado.Direccion_CEDIS;
                    txtTelefonoCEDIS.Text = Convert.ToString(encontrado.Telefono_CEDIS);
                    cmbEstado.Text = encontrado.Estado;
                    txtDescripcionCEDIS.Text = encontrado.Descripcion;
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

