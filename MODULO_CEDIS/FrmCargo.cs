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
    public partial class FrmCargo : Form
    {
        public FrmCargo()
        {
            InitializeComponent();
        }

        CEDISEntities cn = new CEDISEntities();

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de CEDIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (this.txtId.Text == string.Empty && this.txtNomcar.Text == string.Empty && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtNomcar, "Ingrese un nombre a la categoria");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }


            cargo nuevo = new cargo();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);


            nuevo.id = codigo;
            nuevo.Nombre_car = txtNomcar.Text;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;


            cn.cargo.Add(nuevo);

            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del cargo se registraron corectamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los dato no se guardaron");
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (txtId.Text != "" || txtNomcar.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
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
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from car in files.cargo
                               select new
                               {
                                   Codigo = car.id,
                                   Nombre = car.Nombre_car,
                                   Estado = car.Estado,
                                   Descripcion = car.Descripcion,
                               };
                Datos_Vistas.DataSource = ViewData.ToList();
            }

        }

        private void btnCerrarVista_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
