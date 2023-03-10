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
    }
}
