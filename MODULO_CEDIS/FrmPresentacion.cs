using System;
using conexionBD;
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
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }


        CEDISEntities cn = new CEDISEntities();

        private void FrmPresentacion_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public override void Refresh()

        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from pre in files.presentacion
                               select new
                               {
                                   Codigo = pre.id,
                                   Cantidad = pre.Cantidad_reflejada,
                                   Descripción =pre.Descripcion
                               };
                Datos_Vistas.DataSource = ViewData.ToList();

            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtCantReflejada, "Ingrese una cantidad");
                erroricono.SetError(txtDescripcion, "Ingrese una descripción");
            }

            presentacion nuevo = new presentacion();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            int cantidad = 0;
            int.TryParse(txtCantReflejada.Text, out cantidad);

            nuevo.id = codigo;
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Cantidad_reflejada = cantidad;

            cn.presentacion.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos de la presentación se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            if (txtId.Text != "" || txtDescripcion.Text != "" || txtCantReflejada.Text != "")
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

 
    }
}
