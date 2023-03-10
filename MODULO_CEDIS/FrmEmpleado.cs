using conexionBD;
using conexionBD.VistasModels;
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
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }


        CEDISEntities cn = new CEDISEntities();

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            cargarpersona();
            Refresh();
        }
        public void cargarpersona()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
               var lstPersona = (from p in cn.persona
                              select p).ToList();

                cmbPersona.DataSource = lstPersona;
                cmbPersona.ValueMember = "id";
                cmbPersona.DisplayMember = "Nombre";

                if (cmbPersona == null)
                {
                    throw new ArgumentNullException(nameof(cmbPersona));
                }

            }
            
        }
        public override void Refresh()
        {
            using (var files = new CEDISEntities())
            {
                var ViewData = from em in files.empleado
                               join per in files.persona on em.id_per equals per.id
                               select new
                               {
                                   Codigo = em.id,
                                   Codigo_persona = em.id_per,
                                   Nombre = per.Nombre,
                                   INSS = em.No_INSS,
                                   Estado = em.Estado,
                                   Descripcion = em.Descripcion,
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
            if (this.txtId.Text == string.Empty && this.txtInss.Text == string.Empty 
                && this.txtDescripcion.Text == string.Empty && this.cmbEstado.Text == string.Empty)
            {
                MensajeError("Falta ingresar algunos datos, serán remarcados");
                erroricono.SetError(txtId, "Ingrese un Codigo");
                erroricono.SetError(txtInss, "Ingrese un nuemro de INSS");
                erroricono.SetError(txtDescripcion, "Ingrese una Descripción");
                erroricono.SetError(cmbEstado, "Seleccione un campo");
            }

            empleado nuevo = new empleado();

            int codigo = 0;
            int.TryParse(txtId.Text, out codigo);

            nuevo.id = codigo;
            nuevo.id_per = Convert.ToInt32(cmbPersona.SelectedValue.ToString());
            nuevo.No_INSS = txtInss.Text;
            nuevo.Estado = cmbEstado.Text;
            nuevo.Descripcion = txtDescripcion.Text;


            cn.empleado.Add(nuevo);


            try
            {
                if (cn.SaveChanges() == 1)
                {
                    MessageBox.Show("Los datos del empleado se registraron corectamente");
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
            if (txtId.Text != "" || cmbPersona.Text != "" || txtInss.Text != "" || cmbEstado.Text != "" || txtDescripcion.Text != "")
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
    }
}
