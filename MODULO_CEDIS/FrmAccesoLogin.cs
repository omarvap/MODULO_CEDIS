﻿using conexionBD;
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
    public partial class FrmAccesoLogin : Form
    {
        public FrmAccesoLogin()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

         private void FrmAccesoLogin_Load(object sender, EventArgs e)
        {
            cargarsucursal();
            cargarAsigcargo();
            Refresh();
        }
         public void cargarsucursal()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstsur = (from s in cn.sucursal
                              select s).ToList();

                cmbId_sur.DataSource = lstsur;
                cmbId_sur.ValueMember = "id";
                cmbId_sur.DisplayMember = "Nombre_sur";

                if (cmbId_sur == null)
                {
                    throw new ArgumentNullException(nameof(cmbId_sur));
                }
            }
        }
        public void cargarAsigcargo()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstac = (from s in cn.asignar_cargo
                              select s).ToList();

                cmbAsigCargo.DataSource = lstac;
                cmbAsigCargo.ValueMember = "id";

                if (cmbAsigCargo == null)
                {
                    throw new ArgumentNullException(nameof(cmbAsigCargo));
                }
            }
        }
        public override void Refresh()

        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from us in files.usuario
                               join su in files.sucursal on us.id_sur
                               equals su.id
                               select new
                               {
                                   Codigo = us.id,
                                   Cargo = us.id_asig,
                                   Sucursal = su.Nombre_sur,
                                   Nombre_user = us.Name_User,
                                   //Contraseña = us.Pass

                               };
                Datos_Vistas.DataSource = ViewData.ToList();

            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtUser.Text == string.Empty && this.txtPass.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(cmbId_sur, "Seleccione una Sucursal");
                erroricono.SetError(cmbAsigCargo, "Seleccione un cargo asignado");
                erroricono.SetError(txtUser, "Ingrese un nombre de usuario");
                erroricono.SetError(txtPass, "Ingrese una contraseña");
            }

            usuario nuevo = new usuario();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            nuevo.id = codigo;
            nuevo.id_sur = Convert.ToInt32(cmbId_sur.SelectedValue.ToString());
            nuevo.id_asig = Convert.ToInt32(cmbAsigCargo.SelectedValue.ToString());
            nuevo.Name_User = txtUser.Text;
            nuevo.Pass = txtPass.Text;

            cn.usuario.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del usuario se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "" || cmbId_sur.Text != "" || cmbAsigCargo.Text != "" || txtUser.Text != "" || txtPass.Text != "")
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtUser.Text == string.Empty && this.txtPass.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtUser, "Ingrese un nombre de usuario");
                erroricono.SetError(txtPass, "Ingrese una contraseña");
            }

            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Seleccion de la tabla a actualizar.
            var datos = from user in cn.usuario
                        where user.id.ToString() == txtId.Text
                        select user;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                usuario encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.id_sur = Convert.ToInt32(cmbId_sur.SelectedValue.ToString());
                encontrado.id_asig = Convert.ToInt32(cmbAsigCargo.SelectedValue.ToString());
                encontrado.Name_User = txtUser.Text;
                encontrado.Pass = txtPass.Text;
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
                    MessageBox.Show("Los datos del usuario se Actualizaron corectamente");
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
            var datos = from b in buscar.usuario
                        where b.Name_User == txtbuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                usuario encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado el usuarioi: " + encontrado.Name_User);
                txtId.Text = Convert.ToString(encontrado.id);
                cmbId_sur.Text = Convert.ToString(encontrado.id_sur);
                cmbAsigCargo.Text = Convert.ToString(encontrado.id_asig);
                txtUser.Text = encontrado.Name_User;
                txtPass.Text = encontrado.Pass;
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
                var datos = from b in buscar.usuario
                            where b.Name_User == txtbuscar.Text
                            select b;
                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    usuario encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + " Esta vinculado el usuarioi: " + encontrado.Name_User);
                    txtId.Text = Convert.ToString(encontrado.id);
                    cmbId_sur.Text = Convert.ToString(encontrado.id_sur);
                    cmbAsigCargo.Text = Convert.ToString(encontrado.id_asig);
                    txtUser.Text = encontrado.Name_User;
                    txtPass.Text = encontrado.Pass;
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
