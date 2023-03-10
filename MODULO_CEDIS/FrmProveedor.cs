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
    public partial class FrmProveedor : Form
    {
        public FrmProveedor()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            cargarpersona();
            Refresh();
        }
        public void cargarpersona()
        {
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
            using (var files = new CEDISEntities())
            {
                var ViewData = from pro in files.proveedor
                               join per in files.persona on pro.id_per equals per.id
                               select new
                               {
                                   Codigo = pro.id,
                                   Codigo_persona = pro.id_per,
                                   Nombre = per.Nombre,
                                   politica = pro.Politica_venta,
                                   Tiempo_entrega = pro.Tiempo_entrega,
                                   Pagina = pro.SitioWeb,
                                   Estado = pro.Estado,
                                   Observaciones = pro.Observacion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.cmbPolitica.Text == string.Empty 
                && this.txtFechaEntrega.Text == string.Empty && this.txtSitioWeb.Text == string.Empty 
                && this.cmbEstado.Text == string.Empty
                && this.txtObservacion.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(cmbPolitica, "Ingrese una politica del proveedor");
                erroricono.SetError(txtFechaEntrega, "Ingrese un el tiempo de entrega");
                erroricono.SetError(txtSitioWeb, "Ingrese un sitio web");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
                erroricono.SetError(txtObservacion, "Ingrese una obsercaciones");
            }

            proveedor nuevo = new proveedor();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            nuevo.id = codigo;
            nuevo.id_per = Convert.ToInt32(cmbPersona.SelectedValue.ToString());
            nuevo.Politica_venta = cmbPolitica.Text;
            nuevo.Tiempo_entrega = txtFechaEntrega.Text;
            nuevo.SitioWeb = txtSitioWeb.Text;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Observacion = txtObservacion.Text;


            cn.proveedor.Add(nuevo);


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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || cmbPersona.Text != "" || cmbPolitica.Text != "" 
                || txtFechaEntrega.Text != "" || txtSitioWeb.Text != "" || cmbEstado.Text != "" || txtObservacion.Text != "")
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
    }
}
