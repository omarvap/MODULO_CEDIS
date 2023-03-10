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
using System.IO;
using System.Drawing.Imaging;

namespace MODULO_CEDIS
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cargarcategoria();
            cargarpresentacion();
            cargarunidad();
            cargarmarca();
            Refresh();

        }
        public void cargarcategoria()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstCategoria = (from c in cn.categoria
                                  select c).ToList();

                cmbCategoria.DataSource = lstCategoria;
                cmbCategoria.ValueMember = "id";
                cmbCategoria.DisplayMember = "Nombre_Cat";

                if (cmbCategoria == null)
                {
                    throw new ArgumentNullException(nameof(cmbCategoria));
                }
            }
        }
        public void cargarpresentacion()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstPresentacion = (from p in cn.presentacion
                                  select p).ToList();

                cmbPresentacion.DataSource = lstPresentacion;
                cmbPresentacion.ValueMember = "id";
                cmbPresentacion.DisplayMember = "Descripcion";

                if (cmbPresentacion == null)
                {
                    throw new ArgumentNullException(nameof(cmbPresentacion));
                }
            }
        }
        public void cargarunidad()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstUnida = (from u in cn.unidad_medida
                                       select u).ToList();

                cmbUnidad.DataSource = lstUnida;
                cmbUnidad.ValueMember = "id";
                cmbUnidad.DisplayMember = "Nombre_unidad";

                if (cmbUnidad == null)
                {
                    throw new ArgumentNullException(nameof(cmbUnidad));
                }
            }
        }
        public void cargarmarca()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstMarca = (from m in cn.marca
                                select m).ToList();

                cmbMarca.DataSource = lstMarca;
                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "Marca_producto";

                if (cmbMarca == null)
                {
                    throw new ArgumentNullException(nameof(cmbMarca));
                }
            }
        }
        private void btnCargarimg_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos jpg(*.jpg)|*.jpg|Archivos png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = openFileDialog1.FileName;
            }
        }
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from pro in files.producto
                               join cat in files.categoria on pro.id_cat equals cat.id
                               join pre in files.presentacion on pro.id_pres equals pre.id
                               join un in files.unidad_medida on pro.id_unidad equals un.id
                               join mar in files.marca on pro.id_marca equals mar.id
                               select new
                               {
                                   Codigo = pro.id,
                                   Categoria_codigo = pro.id_cat,
                                   Categoria = cat.Nombre_Cat,
                                   Presentacion_codigo = pro.id_pres,
                                   Presentacion = pre.Descripcion,
                                   Unidad_codigo = pro.id_unidad,
                                   Unidad = un.Nombre_unidad,
                                   cantidad = un.Cantidad,
                                   Marca_codigo = pro.id_marca,
                                   Marca = mar.Marca_producto,
                                   Nombre = pro.nombre,
                                   Imagen = pro.imagen,
                                   Estado = pro.Estado,
                                   Descripcion = pro.Descripcion,
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
            if (this.txtId.Text == string.Empty && this.txtNombre.Text == string.Empty
                && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombre, "Ingrese un nombre al producto");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }

            byte[] file = null;
            Stream mystream = openFileDialog1.OpenFile();

            using (MemoryStream ms = new MemoryStream())
            {
                mystream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (CEDISEntities cn = new CEDISEntities())
            {
                producto nuevo = new producto();

                int codigo = 0;
                int.TryParse(txtId.Text, out codigo);

                nuevo.id = codigo;
                nuevo.id_cat = Convert.ToInt32(cmbCategoria.SelectedValue.ToString());
                nuevo.id_pres = Convert.ToInt32(cmbPresentacion.SelectedValue.ToString());
                nuevo.id_unidad = Convert.ToInt32(cmbUnidad.SelectedValue.ToString());
                nuevo.id_marca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                nuevo.nombre = txtNombre.Text;
                nuevo.imagen = file;
                nuevo.Estado = cmbEstado.Text;
                nuevo.Descripcion = txtDescripcion.Text;


                cn.producto.Add(nuevo);
                

                try
                {
                    if (cn.SaveChanges() == 1)
                    {
                        MessageBox.Show("Los datos del producto se registraron corectamente");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Los dato no se guardaron");
                }
            }
                
        }

        private void btnMostrarImage_Click(object sender, EventArgs e)
        {
            if(Datos_Vistas.Rows.Count > 0)
            {
                int id = int.Parse(Datos_Vistas.Rows[Datos_Vistas.CurrentRow.Index].Cells[0].Value.ToString());
                using (CEDISEntities cn = new CEDISEntities())
                {
                    var imagenes = cn.producto.Find(id);

                    MemoryStream ms = new MemoryStream(imagenes.imagen);
                    Bitmap bmp = new Bitmap(ms);
                    pxImagen.Image = bmp;

                }
            }
        }

        private void btnCerrarVista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtNombre.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
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
