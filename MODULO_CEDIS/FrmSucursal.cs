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
    }
}
