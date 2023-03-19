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
            Refresh();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtCantReflejada, "Ingrese una cantidad");
                erroricono.SetError(txtDescripcion, "Ingrese una descripción");
            }
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo para ingresar datos de tipo int.
            int cantidad = 0;
            int.TryParse(txtCantReflejada.Text, out cantidad);
            //Seleccion de la tabla a actualizar.
            var datos = from pre in cn.presentacion
                        where pre.id.ToString() == txtId.Text
                        select pre;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                presentacion encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Descripcion = txtDescripcion.Text;
                encontrado.Cantidad_reflejada = cantidad;
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
                    MessageBox.Show("Los datos de la precentación se Actualizaron corectamente");
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
            var datos = from pre in cn.presentacion
                        where pre.id.ToString() == txtId.Text
                        select pre;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var pre = cn.presentacion.OrderBy(pr => pr.id).First();
                presentacion pres = datos.First();
                cn.presentacion.Remove(pres);
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
                    MessageBox.Show("Los datos de la presentacion se eliminaron corectamente");
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
            var datos = from b in buscar.presentacion
                        where b.Descripcion == txtbuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                presentacion encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado con la descripción: " + encontrado.Descripcion);
                txtId.Text = Convert.ToString(encontrado.id);
                txtDescripcion.Text = encontrado.Descripcion;
                txtCantReflejada.Text = Convert.ToString(encontrado.Cantidad_reflejada);
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
                var datos = from b in buscar.presentacion
                            where b.Descripcion == txtbuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    presentacion encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado con la descripción: " + encontrado.Descripcion);
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtDescripcion.Text = encontrado.Descripcion;
                    txtCantReflejada.Text = Convert.ToString(encontrado.Cantidad_reflejada);
                    txtbuscar.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El sugeto no existe");
                }
            }
        }

        private void btnCerrarVista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
