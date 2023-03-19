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
    public partial class FrmSucursal : Form
    {
        public FrmSucursal()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void FrmSucursal_Load(object sender, EventArgs e)
        {
            cargarCEDIS();
            Refresh();
        }
        public void cargarCEDIS()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstCEDIS = (from p in cn.CEDIS
                                  select p).ToList();

                cmbCEDIS.DataSource = lstCEDIS;
                cmbCEDIS.ValueMember = "id";
                cmbCEDIS.DisplayMember = "Nombre_CEDIS";

                if (cmbCEDIS == null)
                {
                    throw new ArgumentNullException(nameof(cmbCEDIS));
                }

            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNombreSur.Text == string.Empty && this.txtDirSur.Text == string.Empty
              && this.txtTelSur.Text == string.Empty && this.cmbEstado.Text == string.Empty && this.txtDescripcion.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombreSur, "Ingrese un nombre");
                erroricono.SetError(txtDirSur, "Ingrese una Dirección");
                erroricono.SetError(txtTelSur, "Ingrese un numero de telefono");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
                erroricono.SetError(txtDescripcion, "Ingrese una descripción");
            }

            sucursal nuevo = new sucursal();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            int telefono = 0;
            int.TryParse(txtTelSur.Text, out codigo);

            nuevo.id = codigo;
            nuevo.id_CEDIS = Convert.ToInt32(cmbCEDIS.SelectedValue.ToString());
            nuevo.Nombre_sur = txtNombreSur.Text;
            nuevo.Direccion_sur = txtDirSur.Text;
            nuevo.Telefono_sur = telefono;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;


            cn.sucursal.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos de la sucursal se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
            Refresh();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            if (txtId.Text != "" || cmbCEDIS.Text != "" || txtNombreSur.Text != "" || txtDirSur.Text != "" || txtTelSur.Text != ""
                || cmbEstado.Text != "" || txtDescripcion.Text != "")
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
                var ViewData = from sur in files.sucursal
                               join ce in files.CEDIS on sur.id_CEDIS
                               equals ce.id
                               select new
                               {
                                   Codigo = sur.id,
                                   Codigo_CEDIS = sur.id_CEDIS,
                                   Nombre_CEDIS = ce.Nombre_CEDIS,
                                   Nombre_Sucursal = sur.Nombre_sur,
                                   Telefono = sur.Telefono_sur,
                                   Estado = sur.Estado,
                                   Descripción = sur.Descripcion
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNombreSur.Text == string.Empty && this.txtDirSur.Text == string.Empty
                && this.txtTelSur.Text == string.Empty && this.cmbEstado.Text == string.Empty && this.txtDescripcion.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombreSur, "Ingrese un nombre");
                erroricono.SetError(txtDirSur, "Ingrese una Dirección");
                erroricono.SetError(txtTelSur, "Ingrese un numero de telefono");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
                erroricono.SetError(txtDescripcion, "Ingrese una descripción");
            }

            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo para ingresar datos de tipo int.
            int telefono = 0;
            int.TryParse(txtTelSur.Text, out telefono);
            //Seleccion de la tabla a actualizar.
            var datos = from sur in cn.sucursal
                        where sur.id.ToString() == txtId.Text
                        select sur;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                sucursal encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.id_CEDIS = Convert.ToInt32(cmbCEDIS.SelectedValue.ToString());
                encontrado.Nombre_sur = txtNombreSur.Text;
                encontrado.Direccion_sur = txtDirSur.Text;
                encontrado.Telefono_sur = telefono;
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
                    MessageBox.Show("Los datos de la sucursal se Actualizaron corectamente");
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
            var datos = from b in buscar.sucursal
                        where b.Nombre_sur == txtbuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                sucursal encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_sur + " " + encontrado.Direccion_sur);
                txtId.Text = Convert.ToString(encontrado.id);
                cmbCEDIS.Text = Convert.ToString(encontrado.id_CEDIS);
                txtNombreSur.Text = encontrado.Nombre_sur;
                txtDirSur.Text = encontrado.Direccion_sur;
                txtTelSur.Text = Convert.ToString(encontrado.Telefono_sur);
                cmbEstado.Text = encontrado.Estado;
                txtDescripcion.Text = encontrado.Descripcion;
                txtbuscar.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El sugeto no existe");
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Validacion del boton de busqueda de datos.
                CEDISEntities buscar = new CEDISEntities();
                //Seleccion de los datos a buscar
                var datos = from b in buscar.sucursal
                            where b.Nombre_sur == txtbuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    sucursal encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_sur + " " + encontrado.Direccion_sur);
                    txtId.Text = Convert.ToString(encontrado.id);
                    cmbCEDIS.Text = Convert.ToString(encontrado.id_CEDIS);
                    txtNombreSur.Text = encontrado.Nombre_sur;
                    txtDirSur.Text = encontrado.Direccion_sur;
                    txtTelSur.Text = Convert.ToString(encontrado.Telefono_sur);
                    cmbEstado.Text = encontrado.Estado;
                    txtDescripcion.Text = encontrado.Descripcion;
                    txtbuscar.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El sugeto no existe");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
