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
            Refresh();
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNomMarca.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomMarca, "Ingrese un nombre para la marca");
            }

            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Seleccion de la tabla a actualizar.
            var datos = from mar in cn.marca
                        where mar.id.ToString() == txtId.Text
                        select mar;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                marca encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Marca_producto  = txtNomMarca.Text;
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
                    MessageBox.Show("Los datos del almacen se Actualizaron corectamente");
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
            var datos = from mar in cn.marca
                        where mar.id.ToString() == txtId.Text
                        select mar;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var mar = cn.marca.OrderBy(ma => ma.id).First();
                marca marca = datos.First();
                cn.marca.Remove(marca);
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
                    MessageBox.Show("Los datos del almacen se eliminaron corectamente");
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
            var datos = from b in buscar.marca
                        where b.Marca_producto == txtbuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                marca encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Marca_producto + " " );
                txtId.Text = Convert.ToString(encontrado.id);
                txtNomMarca.Text = encontrado.Marca_producto;
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
                var datos = from b in buscar.marca
                            where b.Marca_producto == txtbuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    marca encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Marca_producto + " ");
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtNomMarca.Text = encontrado.Marca_producto;
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

