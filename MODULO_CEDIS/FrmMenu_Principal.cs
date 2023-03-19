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
    public partial class FrmMenu_Principal : Form
    {
        public FrmMenu_Principal()
        {
            InitializeComponent();
            ocultarmenu();
        }
        private void FrmMenu_Principal_Load(object sender, EventArgs e)
        {
            TmHoraFecha.Enabled = true;
        }
        /*Codificacion del diseño modular del sistema CEDIS del proyecto final de produccion III*/
        private Form activo = null;
        private void abripanelhijo(Form panelhijo)
        {
            if (activo != null)
                activo.Close();
            activo = panelhijo;
            panelhijo.TopLevel = false;
            panelhijo.FormBorderStyle = FormBorderStyle.None;
            panelHijoContenedor.Dock = DockStyle.Fill;
            panelHijoContenedor.Controls.Add(panelhijo);
            panelHijoContenedor.Tag = panelhijo;
            panelhijo.BringToFront();
            panelhijo.Show();
        }

        private void ocultarmenu()
        {
            pnlModularRegistro.Visible = false;
            pnlModularAdmin.Visible = false;
            pnlAdministracionBodega.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (pnlModularAdmin.Visible == true)
                pnlModularAdmin.Visible = false;
            if (pnlModularRegistro.Visible == true)
                pnlModularRegistro.Visible = false;
            if (pnlAdministracionBodega.Visible == true)
                pnlAdministracionBodega.Visible = false;

        }

        private void mostarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        
        private void btnRegistroG_Click(object sender, EventArgs e)
        {
            mostarsubmenu(pnlModularRegistro);
        }

        /*Sub menu del sistema CEDIS de Administracion del sistema.*/
        private void btnRegsitrarPer_Click_1(object sender, EventArgs e)
        {      
            //mandar a llamar un fromulario
            abripanelhijo(new FrmRegistro_Genreal());
            ocultarmenu();
        }

        private void btnIngEmpleado_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmEmpleado());
            ocultarmenu();
        }
        private void btnRegCargo_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmCargo());
            ocultarmenu();
        }
        private void btnAsigCargo_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmAsignar_Cargo());
            ocultarmenu();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mostarsubmenu(pnlModularAdmin);
        }
        private void btnIngresoUser_Click_1(object sender, EventArgs e)
        {
           abripanelhijo(new FrmAccesoLogin());
           ocultarmenu();
        }
        /*Sub menu del sistema CEDIS Administracion De Bodegas*/
        private void btnAdminBodega_Click(object sender, EventArgs e)
        {
            mostarsubmenu(pnlAdministracionBodega);
        }

        private void btnBodega_Cental_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmCEDIS());
            ocultarmenu();
        }
        private void btnSucursal_Click(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmSucursal());
            ocultarmenu();
        }


        private void btnCategoria_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmCategoria_Producto());
            ocultarmenu();
        }

        private void btnPresentacion_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmPresentacion());
            ocultarmenu();
        }

        private void btnUnidad_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmUnida_Medida());
            ocultarmenu();
        }

        private void btnMarca_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmMarca_Producto());
            ocultarmenu();
        }

        private void btnProveedor_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmProveedor());
            ocultarmenu();
        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmProducto());
            ocultarmenu();
        }

        private void btnAlmacenABC_Click(object sender, EventArgs e)
        {
            //mandar a llamar un fromulario
            abripanelhijo(new FrmABC());
            ocultarmenu();
        }
        //Para cambiar de usuario
        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar sesón?", "Alvertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                FrmLogin open = new FrmLogin();
                open.Show();
                this.Hide();
            }
             
        }

        private void TmHoraFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }


    }
}
