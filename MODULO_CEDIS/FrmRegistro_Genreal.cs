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
    public partial class FrmRegistro_Genreal : Form
    {
        public FrmRegistro_Genreal()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void FrmRegistro_Genreal_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from per in files.persona
                               select new
                               {
                                   Codigo = per.id,
                                   Nombre = per.Nombre,
                                   Apellido_razon = per.Apellido_razon,
                                   Dirección = per.Direccion,
                                   Telefono = per.Telefono,
                                   DNI = per.DNI,
                                   Estado = per.Estado,
                                   Descripción = per.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNombre.Text == string.Empty && this.txtApe_razon.Text == string.Empty &&
                         this.txtDireccion.Text == string.Empty && this.txtTelefono.Text == string.Empty
                          && this.txtDNI.Text == string.Empty && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombre, "Ingrese un nombre");
                erroricono.SetError(txtApe_razon, "Ingrese un apellido");
                erroricono.SetError(txtDireccion, "Ingrese una direccion");
                erroricono.SetError(txtTelefono, "Ingrese un telefono");
                erroricono.SetError(txtDNI, "Ingrese un numero telefonico");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");


            }

            persona nuevo = new persona();



            int numero = 0;
            int.TryParse(txtTelefono.Text, out numero);

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);


            nuevo.id = codigo;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido_razon = txtApe_razon.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Telefono = numero;
            nuevo.DNI = txtDNI.Text;
            nuevo.Estado = cmbEstado.Text;
            //nuevo.Estado = txtEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;


            cn.persona.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos generales se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtNombre.Text != "" || txtApe_razon.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != ""
              || txtDNI.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
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

        private void btnCerrarvista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
