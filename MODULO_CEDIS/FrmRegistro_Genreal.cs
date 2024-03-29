﻿using conexionBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODULO_CEDIS
{
    public partial class FrmRegistro_Genreal : Form
    {
        public FrmRegistro_Genreal()
        {
            InitializeComponent();
        }

        //LLamado de la base de datos.
        CEDISEntities cn = new CEDISEntities();

        private void FrmRegistro_Genreal_Load(object sender, EventArgs e)
        {
            Refresh();//Carga de los datos guardados mostrado en el datagri.
            combobuscar();//Cargar para la busqueda por estado
        }
        //Procedimiento de vista de datos de la base de datos.
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from per in files.persona
                               select new
                               {
                                   Codigo = per.id,
                                   Nombre = per.Nombre,
                                   Apellido_razon = per.Apellido_razon,
                                   Dirección = per.Direccion,
                                   Telefono = per.Telefono,
                                   DNI = per.DNI,
                                   Estado = per.Estado,
                                   Descripción = per.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }
        }

        //Procedimiento de busqueda con comboboxs 
        public void combobuscar()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstPersona = (from p in cn.persona
                                  select p).ToList();

                cmbFiltrar.DataSource = lstPersona;
                cmbFiltrar.ValueMember = "id";
                cmbFiltrar.DisplayMember = "Estado";

                if(cmbFiltrar.Items.Count > 1)
                {
                    cmbFiltrar.SelectedIndex = -1;
                }
            }
        }
        /*Procedimiento de Ingresar de datos en el sistema*/
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validaciones de los campos de los fromularios que no esten nulos.
            if (this.txtId.Text == string.Empty && this.txtNombre.Text == string.Empty && this.txtApe_razon.Text == string.Empty &&
                         this.txtDireccion.Text == string.Empty && this.txtTelefono.Text == string.Empty
                          && this.txtDNI.Text == string.Empty && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombre, "Ingrese un nombre");
                erroricono.SetError(txtApe_razon, "Ingrese un apellido");
                erroricono.SetError(txtDireccion, "Ingrese una direccion");
                erroricono.SetError(txtTelefono, "Ingrese un telefono");
                erroricono.SetError(txtDNI, "Ingrese un numero telefonico");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            //Llamso de la tabla de la base de datos.
            persona nuevo = new persona();
            //Metodo para ingresar datos de tipo int.
            int numero = 0;
            int.TryParse(txtTelefono.Text, out numero);
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Ingreso de los datos en la base de datos por medio del formulario.
            nuevo.id = codigo;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido_razon = txtApe_razon.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.Telefono = numero;
            nuevo.DNI = txtDNI.Text;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;

            //Aplicar los el ingreso de los datos.
            cn.persona.Add(nuevo);
            //validacion de los datos ingresados son los correctos.
            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos generales se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }

            Refresh();
        }
        /*Procedimiento de Actualizacion de datos en el sistema*/
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNombre.Text == string.Empty && this.txtApe_razon.Text == string.Empty &&
             this.txtDireccion.Text == string.Empty && this.txtTelefono.Text == string.Empty
              && this.txtDNI.Text == string.Empty && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNombre, "Ingrese un nombre");
                erroricono.SetError(txtApe_razon, "Ingrese un apellido");
                erroricono.SetError(txtDireccion, "Ingrese una direccion");
                erroricono.SetError(txtTelefono, "Ingrese un telefono");
                erroricono.SetError(txtDNI, "Ingrese un numero telefonico");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }
            //Metodo para la editar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo para la editar datos de tipo int.
            int numero = 0;
            int.TryParse(txtTelefono.Text, out numero);
            //Seleccion de la tabla a actualizar.
            var datos = from persona in cn.persona
                        where persona.id.ToString() == txtId.Text
                        select persona;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                persona encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.Nombre = txtNombre.Text;
                encontrado.Apellido_razon = txtApe_razon.Text;
                encontrado.Direccion = txtDireccion.Text;
                encontrado.Telefono = numero;
                encontrado.DNI = txtDNI.Text;
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
                    MessageBox.Show("Los datos generales se Actualizaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Actualizaron");
            }

            Refresh();

        }
        //Validacion de eliminar algun registro de la base de datos.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Llamado de la tabla de la base de datos.
            var datos = from p in cn.persona
                        where p.id.ToString() == txtId.Text
                        select p;
            //Validacion de la eliminacion.
            if (datos.Count() > 0)
            {
                var per = cn.persona.OrderBy(pe => pe.id).First();
                persona pers = datos.First();
                cn.persona.Remove(pers);
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
                    MessageBox.Show("Los datos generales se eliminaron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se Eliminaron");
            }
            Refresh();
        }
        /*Procedimiento de cerrar la ventana actual del formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Validacion de cierre si hay datos en los campos del formulario.
            if (txtId.Text != "" || txtNombre.Text != "" || txtApe_razon.Text != "" || txtDireccion.Text != "" || txtTelefono.Text != ""
              || txtDNI.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
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
        /*Procedimiento para cerrar en general*/
        private void btnCerrarvista_Click(object sender, EventArgs e)
        {
            //Validacion de cierre de la vista de los datos.
            this.Close();
        }
        /*Procedimiento de Busqueda de datos en el sistema*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validacion del boton de busqueda de datos.
            CEDISEntities buscar = new CEDISEntities();
            //Seleccion de los datos a buscar
            var datos = from b in buscar.persona
                        where b.Nombre == txtBuscar.Text
                        select b;

            var datos2 = from c in buscar.persona
                         where c.Estado == cmbFiltrar.Text
                         select c;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                persona encontrado = datos.First();
   
                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre + " " + encontrado.Apellido_razon);
                txtId.Text = Convert.ToString(encontrado.id);
                txtNombre.Text = encontrado.Nombre;
                txtApe_razon.Text = encontrado.Apellido_razon;
                txtDireccion.Text = encontrado.Direccion;
                txtTelefono.Text = Convert.ToString(encontrado.Telefono);
                txtDNI.Text = encontrado.DNI;
                cmbEstado.Text = encontrado.Estado;
                txtDescripcion.Text = encontrado.Descripcion;
                txtBuscar.Text = string.Empty;


            }
            //Busqueda con combox filtra
            else if(datos2.Count() > 0)
            {
                persona encontrado2 = datos2.First();

                MessageBox.Show("El codigo es el: " + encontrado2.id + " Esta vinculado como: " + encontrado2.Nombre + " " + encontrado2.Apellido_razon);
                cmbFiltrar.Text = encontrado2.Estado;
                txtId.Text = Convert.ToString(encontrado2.id);
                txtNombre.Text = encontrado2.Nombre;
                txtApe_razon.Text = encontrado2.Apellido_razon;
                txtDireccion.Text = encontrado2.Direccion;
                txtTelefono.Text = Convert.ToString(encontrado2.Telefono);
                txtDNI.Text = encontrado2.DNI;
                cmbEstado.Text = encontrado2.Estado;
                txtDescripcion.Text = encontrado2.Descripcion;
                cmbFiltrar.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El sugeto no existe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReportePerson open = new Reportes.FrmReportePerson();
            open.Show();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //Validacion del boton de busqueda de datos.
                CEDISEntities buscar = new CEDISEntities();
                //Seleccion de los datos a buscar
                var datos = from b in buscar.persona
                            where b.Nombre == txtBuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    persona encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado como: " + encontrado.Nombre + " " + encontrado.Apellido_razon);
                    txtId.Text = Convert.ToString(encontrado.id);
                    txtNombre.Text = encontrado.Nombre;
                    txtApe_razon.Text = encontrado.Apellido_razon;
                    txtDireccion.Text = encontrado.Direccion;
                    txtTelefono.Text = Convert.ToString(encontrado.Telefono);
                    txtDNI.Text = encontrado.DNI;
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
    }

}


