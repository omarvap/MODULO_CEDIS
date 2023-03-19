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
            Refresh();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtUnidad.Text == string.Empty && this.txtCantidad.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtUnidad, "Ingrese una unidad de medida");
                erroricono.SetError(txtCantidad, "Ingrese una cantidad");
            }
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo para ingresar datos de tipo int.
            decimal cantidad = 0;
            decimal.TryParse(txtCantidad.Text, out cantidad);
            //Seleccion de la tabla a actualizar.
            var datos = from un in cn.unidad_medida
                        where un.id.ToString() == txtId.Text
                        select un;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                unidad_medida encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Nombre_unidad = txtUnidad.Text;
                encontrado.Cantidad = cantidad;

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
                    MessageBox.Show("Los datos de la unidad se Actualizaron corectamente");
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
            var datos = from un in cn.unidad_medida
                        where un.id.ToString() == txtId.Text
                        select un;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var un = cn.unidad_medida.OrderBy(u => u.id).First();
                unidad_medida uni = datos.First();
                cn.unidad_medida.Remove(uni);
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
            var datos = from b in buscar.unidad_medida
                        where b.Nombre_unidad == txtbuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                unidad_medida encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_unidad + " " + encontrado.Cantidad);
                txtId.Text = Convert.ToString(encontrado.id);
                txtUnidad.Text = encontrado.Nombre_unidad;
                txtCantidad.Text = Convert.ToString(encontrado.Cantidad);
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
                var datos = from b in buscar.unidad_medida
                            where b.Nombre_unidad == txtbuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    unidad_medida encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_unidad + " " + encontrado.Cantidad);
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtUnidad.Text = encontrado.Nombre_unidad;
                    txtCantidad.Text = Convert.ToString(encontrado.Cantidad);
                }
                else
                {
                    MessageBox.Show("El sugeto no existe");
                }
            }
        }
    }
}
