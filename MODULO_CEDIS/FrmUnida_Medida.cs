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
    public partial class FrmUnida_Medida : Form
    {
        public FrmUnida_Medida()
        {
            InitializeComponent();
        }
        CEDISEntities cn = new CEDISEntities();

        private void FrmUnida_Medida_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from und in files.unidad_medida
                               select new
                               {
                                   Codigo = und.id,
                                   Nombre = und.Nombre_unidad,
                                   Cantidades = und.Cantidad
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

            if (this.txtId.Text == string.Empty && this.txtUnidad.Text == string.Empty && this.txtCantidad.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtUnidad, "Ingrese una unidad de medida");
                erroricono.SetError(txtCantidad, "Ingrese una cantidad");
            }


            unidad_medida nuevo = new unidad_medida();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            decimal cantidad = 0;
            decimal.TryParse(txtCantidad.Text, out cantidad);

            nuevo.id = codigo;
            nuevo.Nombre_unidad = txtUnidad.Text;
            nuevo.Cantidad = cantidad;


            cn.unidad_medida.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos la unidad se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtUnidad.Text != "" || txtCantidad.Text != "")
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
