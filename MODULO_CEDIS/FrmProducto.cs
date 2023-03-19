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
            cargarABC();
            cargarcategoria();
            cargarpresentacion();
            cargarunidad();
            cargarmarca();
            combobuscar();
            Refresh();

        }

        public void cargarABC()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstABC = (from c in cn.ABC
                                    select c).ToList();

                cmbABC.DataSource = lstABC;
                cmbABC.ValueMember = "id";
                cmbABC.DisplayMember = "Nombre_ABC";

                if (cmbABC == null)
                {
                    throw new ArgumentNullException(nameof(cmbCategoria));
                }
            }
        }

        public void combobuscar()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstproduct = (from produc in cn.producto
                                  select produc).ToList();

                cmbbuscar.DataSource = lstproduct;
                cmbbuscar.ValueMember = "id";
                cmbbuscar.DisplayMember = "Estado";

                if (cmbbuscar.Items.Count > 1)
                {
                    cmbbuscar.SelectedIndex = -1;
                }
            }
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
                               join abc in files.ABC on pro.Ubicacion equals abc.id
                               join cat in files.categoria on pro.id_cat equals cat.id
                               join pre in files.presentacion on pro.id_pres equals pre.id
                               join un in files.unidad_medida on pro.id_unidad equals un.id
                               join mar in files.marca on pro.id_marca equals mar.id
                               select new
                               {
                                   Codigo = pro.id,
                                   Estante = pro.Ubicacion,
                                   Colocación = abc.Nombre_ABC,
                                   Categoria_codigo = pro.id_cat,
                                   Categoria = cat.Nombre_Cat,
                                   Presentacion_codigo = pro.id_pres,
                                   Presentacion = pre.Descripcion,
                                   Unidad_codigo = pro.id_unidad,
                                   Unidad = un.Nombre_unidad,
                                   Peso = un.Cantidad,
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
                nuevo.Ubicacion = Convert.ToInt32(cmbABC.SelectedValue.ToString());
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
                Refresh();
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

        private void btnEditar_Click(object sender, EventArgs e)
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
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Seleccion de la tabla a actualizar.
            var datos = from pro in cn.producto
                        where pro.id.ToString() == txtId.Text
                        select pro;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                producto encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Ubicacion = Convert.ToInt32(cmbABC.SelectedValue.ToString()); ;
                encontrado.id_cat = Convert.ToInt32(cmbCategoria.SelectedValue.ToString()); ;
                encontrado.id_pres = Convert.ToInt32(cmbPresentacion.SelectedValue.ToString()); ;
                encontrado.id_unidad = Convert.ToInt32(cmbUnidad.SelectedValue.ToString());
                encontrado.id_marca = Convert.ToInt32(cmbMarca.SelectedValue.ToString());
                encontrado.nombre =txtNombre.Text;
                encontrado.imagen =file;
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
                    MessageBox.Show("Los datos del producto se Actualizaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Actualizaron");
            }

            Refresh();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //Llamado de la tabla de la base de datos.
            var datos = from pro in cn.producto
                        where pro.id.ToString() == txtId.Text
                        select pro;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var prod = cn.producto.OrderBy(pd => pd.id).First();
                producto product = datos.First();
                cn.producto.Remove(product);
            }
            else
            {
                MessageBox.Show("No se encontro resultados.");
            }
            //validacion de la Eliminacion.
            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del producto se eliminaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Eliminaron");
            }
            Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion del boton de busqueda de datos.
            CEDISEntities buscar = new CEDISEntities();
            //Seleccion de los datos a buscar
            var datos = from b in buscar.producto
                        where b.nombre == txtbuscar.Text
                        select b;

            var datos2 = from c in buscar.producto
                         where c.Estado == cmbbuscar.Text
                         select c;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                producto encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.nombre + " " + encontrado.Estado);
                txtId.Text = Convert.ToString(encontrado.id);
                cmbABC.Text = Convert.ToString(encontrado.Ubicacion);
                cmbCategoria.Text = Convert.ToString(encontrado.id_cat);
                cmbPresentacion.Text = Convert.ToString(encontrado.id_pres);
                cmbUnidad.Text = Convert.ToString(encontrado.id_unidad);
                cmbMarca.Text = Convert.ToString(encontrado.id_marca);
                txtNombre.Text = encontrado.nombre;
                cmbEstado.Text = encontrado.Estado;
                txtDescripcion.Text = encontrado.Descripcion;
                txtbuscar.Text = string.Empty;


            }
            //Busqueda con combox filtra
            else if (datos2.Count() > 0)
            {
                producto encontrado2 = datos2.First();

                MessageBox.Show("El codigo es el: " + encontrado2.id + " Esta vinculado como: " + encontrado2.nombre + " " + encontrado2.Estado);
                cmbbuscar.Text = encontrado2.Estado;
                txtId.Text = Convert.ToString(encontrado2.id);
                cmbABC.Text = Convert.ToString(encontrado2.Ubicacion);
                cmbCategoria.Text = Convert.ToString(encontrado2.id_cat);
                cmbPresentacion.Text = Convert.ToString(encontrado2.id_pres);
                cmbUnidad.Text = Convert.ToString(encontrado2.id_unidad);
                cmbMarca.Text = Convert.ToString(encontrado2.id_marca);
                txtNombre.Text = encontrado2.nombre;
                cmbEstado.Text = encontrado2.Estado;
                txtDescripcion.Text = encontrado2.Descripcion;
                cmbbuscar.Text = string.Empty;
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
                var datos = from b in buscar.producto
                            where b.nombre == txtbuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    producto encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.nombre + " " + encontrado.Estado);
                    txtId.Text = Convert.ToString(encontrado.id);
                    cmbABC.Text = Convert.ToString(encontrado.Ubicacion);
                    cmbCategoria.Text = Convert.ToString(encontrado.id_cat);
                    cmbPresentacion.Text = Convert.ToString(encontrado.id_pres);
                    cmbUnidad.Text = Convert.ToString(encontrado.id_unidad);
                    cmbMarca.Text = Convert.ToString(encontrado.id_marca);
                    txtNombre.Text = encontrado.nombre;
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
    }
}
