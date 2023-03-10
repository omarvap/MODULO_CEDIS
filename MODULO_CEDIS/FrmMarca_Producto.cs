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
    public partial class FrmMarca_Producto : Form
    {
        public FrmMarca_Producto()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FrmMarca_Producto_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from mar in files.marca
                               select new
                               {
                                   Codigo = mar.id,
                                   Nombre = mar.Marca_producto
                               };
                Datos_Vistas.DataSource = ViewData.ToList();

            }

        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtNomMarca.Text != "")
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNomMarca.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomMarca, "Ingrese un nombre para la marca");
            }
                marca nuevo = new marca();

                int codigo = 0;
                int.TryParse(txtId.Text, out codigo);

                nuevo.id = codigo;
                nuevo.Marca_producto = txtNomMarca.Text;


                cn.marca.Add(nuevo);

                try
                {
                    if (cn.SaveChanges() == 1)
                    {
                        MessageBox.Show("Los datos de la marca se registraron corectamente");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Los dato no se guardaron");
                }
            }
    }
}

