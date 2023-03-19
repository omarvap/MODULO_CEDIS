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
                erroricono.SetError(dtFechaIngre, "Ingrese una fecha");
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
            Refresh();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNomCat.Text == string.Empty && this.txtDescripcion.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomCat, "Ingrese un nombre a la categoria");
                erroricono.SetError(dtFechaIngre, "Ingrese una fecha");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");

            }

            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Seleccion de la tabla a actualizar.
            var datos = from ABC in cn.categoria
                        where ABC.id.ToString() == txtId.Text
                        select ABC;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                categoria encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Nombre_Cat = txtNomCat.Text;
                encontrado.Fecha_registro = Convert.ToDateTime(dtFechaIngre.Value.Date.ToString("dd-MM-yyyy"));
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
                    MessageBox.Show("Los datos del almacen se Actualizaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Actualizaron");
            }

            Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion del boton de busqueda de datos.
            CEDISEntities buscar = new CEDISEntities();
            //Seleccion de los datos a buscar
            var datos = from b in buscar.categoria
                        where b.Nombre_Cat == txtbuscar.Text
                        select b;
            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                categoria encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_Cat + " " + encontrado.Fecha_registro);
                txtId.Text = Convert.ToString(encontrado.id);
                txtNomCat.Text = encontrado.Nombre_Cat;
                dtFechaIngre.Text = Convert.ToString(encontrado.Fecha_registro);
                txtDescripcion.Text = encontrado.Descripcion;
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
                var datos = from b in buscar.categoria
                            where b.Nombre_Cat == txtbuscar.Text
                            select b;
                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    categoria encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_Cat + " " + "Fue registrado: "+ encontrado.Fecha_registro);
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtNomCat.Text = encontrado.Nombre_Cat;
                    dtFechaIngre.Text = Convert.ToString(encontrado.Fecha_registro);
                    txtDescripcion.Text = encontrado.Descripcion;
                    txtbuscar.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El sugeto no existe");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Llamado de la tabla de la base de datos.
            var datos = from cat in cn.categoria
                        where cat.id.ToString() == txtId.Text
                        select cat;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var cat = cn.categoria.OrderBy(ca => ca.id).First();
                categoria cate = datos.First();
                cn.categoria.Remove(cate);
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
    }
}
