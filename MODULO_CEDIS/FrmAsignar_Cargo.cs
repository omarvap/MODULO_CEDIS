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
    public partial class FrmAsignar_Cargo : Form
    {
        public FrmAsignar_Cargo()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();
        private void FrmAsignar_Cargo_Load(object sender, EventArgs e)
        {
            cargarempleado();
            cargarcargo();
            Refresh();
        }
        public void cargarempleado()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstempleado = (from p in cn.empleado
                                   select p).ToList();

                cmbEmpleado.DataSource = lstempleado;
                cmbEmpleado.ValueMember = "id";
                cmbEmpleado.DisplayMember = "id_empleado";

                try
                {
                    if (cmbEmpleado == null)
                    {
                        throw new ArgumentNullException(nameof(cmbEmpleado));
                    }
                }
                catch (Exception)
                {
                    if (cmbEmpleado.Items.Count > 1)
                    {
                        cmbEmpleado.SelectedIndex = -1;
                    }
                }

            }

        }
        public void cargarcargo()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstcargo = (from c in cn.cargo
                                  select c).ToList();

                cmbCargo.DataSource = lstcargo;
                cmbCargo.ValueMember = "id";
                cmbCargo.DisplayMember = "Nombre_car";

                 try
                {
                    if (cmbCargo == null)
                    {
                        throw new ArgumentNullException(nameof(cmbCargo));
                    }
                }
                catch (Exception)
                {
                    if (cmbCargo.Items.Count > 1)
                    {
                        cmbCargo.SelectedIndex = -1;
                    }
                }

            }
        }
        public override void Refresh()

        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from ac in files.asignar_cargo
                               join em in files.empleado on ac.id_empleado equals em.id
                               join per in files.persona on em.id_per equals per.id
                               join car in files.cargo on ac.id_cargo equals car.id
                               select new
                               {
                                   Codigo = ac.id,
                                   Codigo_Empleado = ac.id_empleado,
                                   Nombre_Empleado = per.Nombre,
                                   Codigo_Cargo = ac.id_cargo,
                                   Nombre_Cargo = car.Nombre_car
                               };
                Datos_Vistas.DataSource = ViewData.ToList();

            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(cmbCargo, "Seleccione un cargo");
                erroricono.SetError(cmbEmpleado, "Seleccione un empleado");
            }

            asignar_cargo nuevo = new asignar_cargo();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            nuevo.id = codigo;
            nuevo.id_empleado = Convert.ToInt32(cmbEmpleado.SelectedValue.ToString());
            nuevo.id_cargo = Convert.ToInt32(cmbEmpleado.SelectedValue.ToString());

            cn.asignar_cargo.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos de la asignación de cargo se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "" || cmbEmpleado.Text != "" || cmbCargo.Text != "")
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(cmbCargo, "Seleccione un cargo");
                erroricono.SetError(cmbEmpleado, "Seleccione un empleado");
            }
            //Metodo para ingresar datos de tipo int.
            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);
            //Metodo de ingresar datos decimales
            var datos = from asi in cn.asignar_cargo
                        where asi.id.ToString() == txtId.Text
                        select asi;
            //Validacion de los datos a actualizar.
            if (datos.Count() > 0)
            {
                asignar_cargo encontrado = datos.First();

                encontrado.id = codigo;
                encontrado.id_empleado =Convert.ToInt32(cmbEmpleado.SelectedValue.ToString());
                encontrado.id_cargo =Convert.ToInt32(cmbCargo.SelectedValue.ToString());
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
                    MessageBox.Show("Los datos de la asignacion de cargo se Actualizaron corectamente");
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
            var datos = from b in buscar.asignar_cargo
                        join em in buscar.empleado on b.id_empleado equals em.id
                        join per in buscar.persona on em.id_per equals per.id
                        where per.Nombre == txtbuscar.Text
                        select b;

            //Busqueda con txtbuscar
            if (datos.Count() > 0)
            {
                asignar_cargo encontrado = datos.First();

                MessageBox.Show("El codigo es el: " + encontrado.id + "El cargo asignado es el: " + encontrado.cargo.Nombre_car);
                txtId.Text = Convert.ToString(encontrado.id);
                cmbCargo.Text = Convert.ToString(encontrado.id_cargo);
                cmbCargo.Text = Convert.ToString(encontrado.id_empleado);
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
                var datos = from b in buscar.asignar_cargo
                            join em in buscar.empleado on b.id_empleado equals em.id
                            join per in buscar.persona on em.id_per equals per.id
                            where per.Nombre == txtbuscar.Text
                            select b;

                //Busqueda con txtbuscar
                if (datos.Count() > 0)
                {
                    asignar_cargo encontrado = datos.First();

                    MessageBox.Show("El codigo es el: " + encontrado.id + "El cargo asignado es el: " + encontrado.cargo.Nombre_car);
                    txtId.Text = Convert.ToString(encontrado.id);
                    cmbCargo.Text = Convert.ToString(encontrado.id_cargo);
                    cmbCargo.Text = Convert.ToString(encontrado.id_empleado);
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
