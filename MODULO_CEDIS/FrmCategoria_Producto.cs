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
    public partial class FrmCategoria_Producto : Form
    {
        public FrmCategoria_Producto()
        {
            InitializeComponent();
        }
        CEDISEntities cn = new CEDISEntities();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" ||  txtNomCat.Text != "" || txtDescripcion.Text != "")
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
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNomCat.Text == string.Empty && this.txtDescripcion.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomCat, "Ingrese un nombre a la categoria");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                
            }

            categoria nuevo = new categoria(); 

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            nuevo.id = codigo;
            nuevo.Nombre_Cat = txtNomCat.Text;
            nuevo.Fecha_registro= Convert.ToDateTime(dtFechaIngre.Value.Date.ToString("dd-MM-yyyy"));
            nuevo.Descripcion = txtDescripcion.Text;


            cn.categoria.Add(nuevo);


            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos de la categoria se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void FrmCategoria_Producto_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from cat in files.categoria
                               select new
                               {
                                   Codigo = cat.id,
                                   Nombre = cat.Nombre_Cat,
                                   Fecha = cat.Fecha_registro,
                                   Descripción = cat.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }

        }

        private void btnCerrarvista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
