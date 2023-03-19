using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexionBD;

namespace MODULO_CEDIS
{
  
    public partial class FrmABC : Form
    {
        public FrmABC()
        {
            InitializeComponent();
        }
        CEDISEntities cn = new CEDISEntities();
        private void FrmABC_Load(object sender, EventArgs e)
        {
            Refresh(); //Carga de los datos guardados mostrado en el datagri.
            combobuscar();//Cargar para la busqueda por nombre ABC
        }
        //Procedimiento de vista de datos de la base de datos.
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from abc in files.ABC
                               select new
                               {
                                   Codigo = abc.id,
                                   Nombre = abc.Nombre_ABC,
                                   Tipo = abc.Tipo_ABC,
                                   Peso_Maximo = abc.Peso_max,
                                   Peso_Minimo = abc.Peso_min,
                                   Estado = abc.Estado,
                                   Descripción = abc.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }
        }

        //Procedimiento de busqueda con comboboxs 
        public void combobuscar()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstABC = (from p in cn.ABC
                                  select p).ToList();

                cmbFiltrar.DataSource = lstABC;
                cmbFiltrar.ValueMember = "id";
                cmbFiltrar.DisplayMember = "Estado";

                if (cmbFiltrar.Items.Count > 1)
                {
                    cmbFiltrar.SelectedIndex = -1;
                }
            }
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validaciones de los campos de los fromularios que no esten nulos.
            if (this.txtId.Text == string.Empty && this.cmbNombreABC.Text == string.Empty && this.txtTipoABC.Text == string.Empty &&
                         this.txtPesoMax.Text == string.Empty && this.txtPesoMin.Text == string.Empty
                         && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(cmbNombreABC, "Ingrese un nombre");
                erroricono.SetError(txtTipoABC, "Ingrese un tipo de ABC");
                erroricono.SetError(txtPesoMax, "Ingrese el peso maximo");
                erroricono.SetError(txtPesoMin, "Ingrese el peso minimo");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            //Llamado de la tabla de la base de datos.
            ABC nuevo = new ABC();
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo de ingresar datos decimales
            decimal maximo = 0;
            decimal.TryParse(txtPesoMax.Text, out maximo);
            //Metodo de ingresar datos decimales
            decimal minimo = 0;
            decimal.TryParse(txtPesoMin.Text, out minimo);
            //Ingreso de los datos en la base de datos por medio del formulario.
            nuevo.id = codigo;
            nuevo.Nombre_ABC = cmbNombreABC.Text;
            nuevo.Tipo_ABC = txtTipoABC.Text;
            nuevo.Peso_max = maximo;
            nuevo.Peso_min = minimo;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;

            //Aplicar los el ingreso de los datos.
            cn.ABC.Add(nuevo);
            //validacion de los datos ingresados son los correctos.
            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del almacen se registraron corectamente");
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
            //Validaciones de los campos de los fromularios que no esten nulos.
            if (this.txtId.Text == string.Empty && this.cmbNombreABC.Text == string.Empty && this.txtTipoABC.Text == string.Empty &&
                 this.txtPesoMax.Text == string.Empty && this.txtPesoMin.Text == string.Empty
                 && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(cmbNombreABC, "Ingrese un nombre");
                erroricono.SetError(txtTipoABC, "Ingrese un tipo de ABC");
                erroricono.SetError(txtPesoMax, "Ingrese el peso maximo");
                erroricono.SetError(txtPesoMin, "Ingrese el peso minimo");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo de ingresar datos decimales
            decimal maximo = 0;
            decimal.TryParse(txtPesoMax.Text, out maximo);
            //Metodo de ingresar datos decimales
            decimal minimo = 0;
            decimal.TryParse(txtPesoMin.Text, out minimo);
            //Seleccion de la tabla a actualizar.
            var datos = from ABC in cn.ABC
                        where ABC.id.ToString() == txtId.Text
                        select ABC;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                ABC encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Nombre_ABC = cmbNombreABC.Text;
                encontrado.Tipo_ABC = txtTipoABC.Text;
                encontrado.Peso_max = maximo;
                encontrado.Peso_min = minimo;
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
            var datos = from abc in cn.ABC
                        where abc.id.ToString() == txtId.Text
                        select abc;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var abc = cn.ABC.OrderBy(a => a.id).First();
                ABC alm = datos.First();
                cn.ABC.Remove(alm);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Validacion de cierre si hay datos en los campos del formulario.
            if (txtId.Text != "" || cmbNombreABC.Text != "" || txtTipoABC.Text != "" || txtPesoMax.Text != "" || txtPesoMin.Text != ""
                || cmbEstado.Text != "" || txtDescripcion.Text != "")
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

        private void btnCerrarvista_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion del boton de busqueda de datos.
            CEDISEntities buscar = new CEDISEntities();
            //Seleccion de los datos a buscar
            var datos = from b in buscar.ABC
                        where b.Nombre_ABC == txtBuscar.Text
                        select b;

            var datos2 = from c in buscar.ABC
                         where c.Estado == cmbFiltrar.Text
                         select c;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                ABC encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_ABC + " " + encontrado.Tipo_ABC);
                txtId.Text = Convert.ToString(encontrado.id);
                cmbNombreABC.Text = encontrado.Nombre_ABC;
                txtTipoABC.Text = encontrado.Tipo_ABC;
                txtPesoMax.Text = Convert.ToString(encontrado.Peso_max);
                txtPesoMin.Text = Convert.ToString(encontrado.Peso_min);
                cmbEstado.Text = encontrado.Estado;
                txtDescripcion.Text = encontrado.Descripcion;
                txtBuscar.Text = string.Empty;


            }
            //Busqueda con combox filtra
            else if (datos2.Count() > 0)
            {
                ABC encontrado2 = datos2.First();

                MessageBox.Show("El codigo es el: " + encontrado2.id + " Esta vinculado como: " + encontrado2.Nombre_ABC + " " + encontrado2.Tipo_ABC);
                cmbFiltrar.Text = encontrado2.Estado;
                txtId.Text = Convert.ToString(encontrado2.id);
                cmbNombreABC.Text = encontrado2.Nombre_ABC;
                txtTipoABC.Text = encontrado2.Tipo_ABC;
                txtPesoMax.Text = Convert.ToString(encontrado2.Peso_max);
                txtPesoMin.Text = Convert.ToString(encontrado2.Peso_min);
                cmbEstado.Text = encontrado2.Estado;
                txtDescripcion.Text = encontrado2.Descripcion;
                cmbFiltrar.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El sugeto no existe");
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Validacion del boton de busqueda de datos.
                CEDISEntities buscar = new CEDISEntities();
                //Seleccion de los datos a buscar
                var datos = from b in buscar.ABC
                            where b.Nombre_ABC == txtBuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    ABC encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre_ABC + " " + encontrado.Tipo_ABC);
                    txtId.Text = Convert.ToString(encontrado.id);
                    cmbNombreABC.Text = encontrado.Nombre_ABC;
                    txtTipoABC.Text = encontrado.Tipo_ABC;
                    txtPesoMax.Text = Convert.ToString(encontrado.Peso_max);
                    txtPesoMin.Text = Convert.ToString(encontrado.Peso_min);
                    cmbEstado.Text = encontrado.Estado;
                    txtDescripcion.Text = encontrado.Descripcion;
                    txtBuscar.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El sugeto no existe");
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
