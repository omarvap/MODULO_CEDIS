namespace MODULO_CEDIS
{
    partial class FrmMenu_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu_Principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlAdministracionBodega = new System.Windows.Forms.Panel();
            this.pnlModularAdmin = new System.Windows.Forms.Panel();
            this.pnlModularRegistro = new System.Windows.Forms.Panel();
            this.panelHijoContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnUnidad = new System.Windows.Forms.Button();
            this.btnPresentacion = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnSucursal = new System.Windows.Forms.Button();
            this.btnBodega_Cental = new System.Windows.Forms.Button();
            this.btnAdminBodega = new System.Windows.Forms.Button();
            this.btnIngresoUser = new System.Windows.Forms.Button();
            this.btnAsigCargo = new System.Windows.Forms.Button();
            this.btnRegCargo = new System.Windows.Forms.Button();
            this.btnIngEmpleado = new System.Windows.Forms.Button();
            this.btnRegsitrarPer = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRegistroG = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.pnlAdministracionBodega.SuspendLayout();
            this.pnlModularAdmin.SuspendLayout();
            this.panelHijoContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.pnlAdministracionBodega);
            this.panelMenu.Controls.Add(this.btnAdminBodega);
            this.panelMenu.Controls.Add(this.pnlModularAdmin);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.pnlModularRegistro);
            this.panelMenu.Controls.Add(this.btnRegistroG);
            this.panelMenu.Controls.Add(this.panel);
            this.panelMenu.Name = "panelMenu";
            // 
            // pnlAdministracionBodega
            // 
            this.pnlAdministracionBodega.BackColor = System.Drawing.Color.White;
            this.pnlAdministracionBodega.Controls.Add(this.btnProducto);
            this.pnlAdministracionBodega.Controls.Add(this.btnProveedor);
            this.pnlAdministracionBodega.Controls.Add(this.btnMarca);
            this.pnlAdministracionBodega.Controls.Add(this.btnUnidad);
            this.pnlAdministracionBodega.Controls.Add(this.btnPresentacion);
            this.pnlAdministracionBodega.Controls.Add(this.btnCategoria);
            this.pnlAdministracionBodega.Controls.Add(this.btnSucursal);
            this.pnlAdministracionBodega.Controls.Add(this.btnBodega_Cental);
            resources.ApplyResources(this.pnlAdministracionBodega, "pnlAdministracionBodega");
            this.pnlAdministracionBodega.Name = "pnlAdministracionBodega";
            // 
            // pnlModularAdmin
            // 
            this.pnlModularAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.pnlModularAdmin.Controls.Add(this.btnIngresoUser);
            this.pnlModularAdmin.Controls.Add(this.btnAsigCargo);
            this.pnlModularAdmin.Controls.Add(this.btnRegCargo);
            this.pnlModularAdmin.Controls.Add(this.btnIngEmpleado);
            this.pnlModularAdmin.Controls.Add(this.btnRegsitrarPer);
            resources.ApplyResources(this.pnlModularAdmin, "pnlModularAdmin");
            this.pnlModularAdmin.Name = "pnlModularAdmin";
            // 
            // pnlModularRegistro
            // 
            this.pnlModularRegistro.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.pnlModularRegistro, "pnlModularRegistro");
            this.pnlModularRegistro.Name = "pnlModularRegistro";
            // 
            // panelHijoContenedor
            // 
            this.panelHijoContenedor.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelHijoContenedor, "panelHijoContenedor");
            this.panelHijoContenedor.Name = "panelHijoContenedor";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnProducto
            // 
            resources.ApplyResources(this.btnProducto, "btnProducto");
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.Image = global::MODULO_CEDIS.Properties.Resources.paquete;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnProveedor
            // 
            resources.ApplyResources(this.btnProveedor, "btnProveedor");
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.Image = global::MODULO_CEDIS.Properties.Resources.repartidor;
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnMarca
            // 
            resources.ApplyResources(this.btnMarca, "btnMarca");
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.Image = global::MODULO_CEDIS.Properties.Resources.marca;
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnUnidad
            // 
            resources.ApplyResources(this.btnUnidad, "btnUnidad");
            this.btnUnidad.FlatAppearance.BorderSize = 0;
            this.btnUnidad.Image = global::MODULO_CEDIS.Properties.Resources.bascula;
            this.btnUnidad.Name = "btnUnidad";
            this.btnUnidad.UseVisualStyleBackColor = true;
            this.btnUnidad.Click += new System.EventHandler(this.btnUnidad_Click);
            // 
            // btnPresentacion
            // 
            resources.ApplyResources(this.btnPresentacion, "btnPresentacion");
            this.btnPresentacion.FlatAppearance.BorderSize = 0;
            this.btnPresentacion.Image = global::MODULO_CEDIS.Properties.Resources.producto;
            this.btnPresentacion.Name = "btnPresentacion";
            this.btnPresentacion.UseVisualStyleBackColor = true;
            this.btnPresentacion.Click += new System.EventHandler(this.btnPresentacion_Click);
            // 
            // btnCategoria
            // 
            resources.ApplyResources(this.btnCategoria, "btnCategoria");
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.Image = global::MODULO_CEDIS.Properties.Resources.surtido;
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnSucursal
            // 
            resources.ApplyResources(this.btnSucursal, "btnSucursal");
            this.btnSucursal.FlatAppearance.BorderSize = 0;
            this.btnSucursal.Image = global::MODULO_CEDIS.Properties.Resources.trabajar_desde_casa;
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.UseVisualStyleBackColor = true;
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // btnBodega_Cental
            // 
            resources.ApplyResources(this.btnBodega_Cental, "btnBodega_Cental");
            this.btnBodega_Cental.FlatAppearance.BorderSize = 0;
            this.btnBodega_Cental.Image = global::MODULO_CEDIS.Properties.Resources.almacenamiento;
            this.btnBodega_Cental.Name = "btnBodega_Cental";
            this.btnBodega_Cental.UseVisualStyleBackColor = true;
            this.btnBodega_Cental.Click += new System.EventHandler(this.btnBodega_Cental_Click_1);
            // 
            // btnAdminBodega
            // 
            resources.ApplyResources(this.btnAdminBodega, "btnAdminBodega");
            this.btnAdminBodega.FlatAppearance.BorderSize = 0;
            this.btnAdminBodega.ForeColor = System.Drawing.Color.White;
            this.btnAdminBodega.Image = global::MODULO_CEDIS.Properties.Resources.compra_local;
            this.btnAdminBodega.Name = "btnAdminBodega";
            this.btnAdminBodega.UseVisualStyleBackColor = true;
            this.btnAdminBodega.Click += new System.EventHandler(this.btnAdminBodega_Click);
            // 
            // btnIngresoUser
            // 
            resources.ApplyResources(this.btnIngresoUser, "btnIngresoUser");
            this.btnIngresoUser.FlatAppearance.BorderSize = 0;
            this.btnIngresoUser.Image = global::MODULO_CEDIS.Properties.Resources.perfil_del_usuario;
            this.btnIngresoUser.Name = "btnIngresoUser";
            this.btnIngresoUser.UseVisualStyleBackColor = true;
            this.btnIngresoUser.Click += new System.EventHandler(this.btnIngresoUser_Click_1);
            // 
            // btnAsigCargo
            // 
            resources.ApplyResources(this.btnAsigCargo, "btnAsigCargo");
            this.btnAsigCargo.FlatAppearance.BorderSize = 0;
            this.btnAsigCargo.Image = global::MODULO_CEDIS.Properties.Resources.delegar;
            this.btnAsigCargo.Name = "btnAsigCargo";
            this.btnAsigCargo.UseVisualStyleBackColor = true;
            this.btnAsigCargo.Click += new System.EventHandler(this.btnAsigCargo_Click_1);
            // 
            // btnRegCargo
            // 
            resources.ApplyResources(this.btnRegCargo, "btnRegCargo");
            this.btnRegCargo.FlatAppearance.BorderSize = 0;
            this.btnRegCargo.Image = global::MODULO_CEDIS.Properties.Resources.gestion_de_equipos;
            this.btnRegCargo.Name = "btnRegCargo";
            this.btnRegCargo.UseVisualStyleBackColor = true;
            this.btnRegCargo.Click += new System.EventHandler(this.btnRegCargo_Click_1);
            // 
            // btnIngEmpleado
            // 
            resources.ApplyResources(this.btnIngEmpleado, "btnIngEmpleado");
            this.btnIngEmpleado.FlatAppearance.BorderSize = 0;
            this.btnIngEmpleado.Image = global::MODULO_CEDIS.Properties.Resources.empresario;
            this.btnIngEmpleado.Name = "btnIngEmpleado";
            this.btnIngEmpleado.UseVisualStyleBackColor = true;
            this.btnIngEmpleado.Click += new System.EventHandler(this.btnIngEmpleado_Click_1);
            // 
            // btnRegsitrarPer
            // 
            resources.ApplyResources(this.btnRegsitrarPer, "btnRegsitrarPer");
            this.btnRegsitrarPer.FlatAppearance.BorderSize = 0;
            this.btnRegsitrarPer.Image = global::MODULO_CEDIS.Properties.Resources.anadir_grupo;
            this.btnRegsitrarPer.Name = "btnRegsitrarPer";
            this.btnRegsitrarPer.UseVisualStyleBackColor = true;
            this.btnRegsitrarPer.Click += new System.EventHandler(this.btnRegsitrarPer_Click_1);
            // 
            // btnAdmin
            // 
            resources.ApplyResources(this.btnAdmin, "btnAdmin");
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Image = global::MODULO_CEDIS.Properties.Resources.admin;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRegistroG
            // 
            resources.ApplyResources(this.btnRegistroG, "btnRegistroG");
            this.btnRegistroG.FlatAppearance.BorderSize = 0;
            this.btnRegistroG.ForeColor = System.Drawing.Color.White;
            this.btnRegistroG.Image = global::MODULO_CEDIS.Properties.Resources.la_gestion_del_inventario;
            this.btnRegistroG.Name = "btnRegistroG";
            this.btnRegistroG.UseVisualStyleBackColor = true;
            this.btnRegistroG.Click += new System.EventHandler(this.btnRegistroG_Click);
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // FrmMenu_Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelHijoContenedor);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMenu_Principal";
            this.panelMenu.ResumeLayout(false);
            this.pnlAdministracionBodega.ResumeLayout(false);
            this.pnlModularAdmin.ResumeLayout(false);
            this.panelHijoContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel pnlModularRegistro;
        private System.Windows.Forms.Button btnRegistroG;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pnlAdministracionBodega;
        private System.Windows.Forms.Button btnAdminBodega;
        private System.Windows.Forms.Panel pnlModularAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel panelHijoContenedor;
        private System.Windows.Forms.Button btnRegsitrarPer;
        private System.Windows.Forms.Button btnIngresoUser;
        private System.Windows.Forms.Button btnAsigCargo;
        private System.Windows.Forms.Button btnRegCargo;
        private System.Windows.Forms.Button btnIngEmpleado;
        private System.Windows.Forms.Button btnSucursal;
        private System.Windows.Forms.Button btnBodega_Cental;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnPresentacion;
        private System.Windows.Forms.Button btnUnidad;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnProveedor;
    }
}