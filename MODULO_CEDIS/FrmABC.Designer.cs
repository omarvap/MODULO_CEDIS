namespace MODULO_CEDIS
{
    partial class FrmABC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmABC));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gbopciones = new System.Windows.Forms.GroupBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCerrarvista = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Datos_Vistas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.txtPesoMin = new System.Windows.Forms.TextBox();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.txtTipoABC = new System.Windows.Forms.TextBox();
            this.cmbNombreABC = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpBusqueda.SuspendLayout();
            this.gbopciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Vistas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 537);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.gpBusqueda);
            this.tabPage1.Controls.Add(this.gbopciones);
            this.tabPage1.Controls.Add(this.Datos_Vistas);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista";
            // 
            // gpBusqueda
            // 
            this.gpBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpBusqueda.Controls.Add(this.cmbFiltrar);
            this.gpBusqueda.Controls.Add(this.txtBuscar);
            this.gpBusqueda.Controls.Add(this.btnBuscar);
            this.gpBusqueda.Controls.Add(this.label13);
            this.gpBusqueda.Controls.Add(this.label14);
            this.gpBusqueda.Controls.Add(this.label15);
            this.gpBusqueda.Controls.Add(this.label16);
            this.gpBusqueda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBusqueda.Location = new System.Drawing.Point(6, 6);
            this.gpBusqueda.Name = "gpBusqueda";
            this.gpBusqueda.Size = new System.Drawing.Size(702, 114);
            this.gpBusqueda.TabIndex = 7;
            this.gpBusqueda.TabStop = false;
            this.gpBusqueda.Text = "&Busqueda";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(230, 70);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(160, 32);
            this.cmbFiltrar.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(21, 70);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(183, 32);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.Location = new System.Drawing.Point(597, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(61, 33);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(-293, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "&Buscar";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(226, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "&Filtrar por:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(17, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 24);
            this.label15.TabIndex = 2;
            this.label15.Text = "Busqueda por:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(593, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "&Buscar";
            // 
            // gbopciones
            // 
            this.gbopciones.Controls.Add(this.btnReporte);
            this.gbopciones.Controls.Add(this.btnCerrarvista);
            this.gbopciones.Controls.Add(this.label17);
            this.gbopciones.Controls.Add(this.label18);
            this.gbopciones.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbopciones.Location = new System.Drawing.Point(587, 148);
            this.gbopciones.Name = "gbopciones";
            this.gbopciones.Size = new System.Drawing.Size(112, 235);
            this.gbopciones.TabIndex = 6;
            this.gbopciones.TabStop = false;
            this.gbopciones.Text = "&Opciones";
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.Transparent;
            this.btnReporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReporte.BackgroundImage")));
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Location = new System.Drawing.Point(38, 46);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(48, 38);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnCerrarvista
            // 
            this.btnCerrarvista.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarvista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarvista.BackgroundImage")));
            this.btnCerrarvista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarvista.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCerrarvista.FlatAppearance.BorderSize = 0;
            this.btnCerrarvista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarvista.Location = new System.Drawing.Point(39, 148);
            this.btnCerrarvista.Name = "btnCerrarvista";
            this.btnCerrarvista.Size = new System.Drawing.Size(47, 47);
            this.btnCerrarvista.TabIndex = 1;
            this.btnCerrarvista.UseVisualStyleBackColor = false;
            this.btnCerrarvista.Click += new System.EventHandler(this.btnCerrarvista_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(34, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "&Cerrar";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(25, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 24);
            this.label18.TabIndex = 2;
            this.label18.Text = "&Reporte";
            // 
            // Datos_Vistas
            // 
            this.Datos_Vistas.AllowUserToOrderColumns = true;
            this.Datos_Vistas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Datos_Vistas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Datos_Vistas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datos_Vistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos_Vistas.Location = new System.Drawing.Point(6, 148);
            this.Datos_Vistas.Name = "Datos_Vistas";
            this.Datos_Vistas.Size = new System.Drawing.Size(546, 327);
            this.Datos_Vistas.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.gbContenedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(538, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 362);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Opciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(46, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "&Cerrar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(46, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "&Eliminar";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(46, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Editar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(46, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "&Guardar";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.disquete;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Location = new System.Drawing.Point(51, 34);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(44, 43);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(51, 271);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 49);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.boton_eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(51, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 49);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(51, 109);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 55);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbContenedor
            // 
            this.gbContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContenedor.Controls.Add(this.txtPesoMin);
            this.gbContenedor.Controls.Add(this.txtPesoMax);
            this.gbContenedor.Controls.Add(this.txtTipoABC);
            this.gbContenedor.Controls.Add(this.cmbNombreABC);
            this.gbContenedor.Controls.Add(this.cmbEstado);
            this.gbContenedor.Controls.Add(this.txtId);
            this.gbContenedor.Controls.Add(this.label8);
            this.gbContenedor.Controls.Add(this.label2);
            this.gbContenedor.Controls.Add(this.label1);
            this.gbContenedor.Controls.Add(this.label7);
            this.gbContenedor.Controls.Add(this.txtDescripcion);
            this.gbContenedor.Controls.Add(this.label6);
            this.gbContenedor.Controls.Add(this.label3);
            this.gbContenedor.Controls.Add(this.label4);
            this.gbContenedor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(19, 22);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(490, 464);
            this.gbContenedor.TabIndex = 9;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "&Ingreso de datos";
            // 
            // txtPesoMin
            // 
            this.txtPesoMin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoMin.Location = new System.Drawing.Point(208, 241);
            this.txtPesoMin.Multiline = true;
            this.txtPesoMin.Name = "txtPesoMin";
            this.txtPesoMin.Size = new System.Drawing.Size(79, 24);
            this.txtPesoMin.TabIndex = 1;
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoMax.Location = new System.Drawing.Point(208, 191);
            this.txtPesoMax.Multiline = true;
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.Size = new System.Drawing.Size(79, 24);
            this.txtPesoMax.TabIndex = 1;
            // 
            // txtTipoABC
            // 
            this.txtTipoABC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoABC.Location = new System.Drawing.Point(208, 147);
            this.txtTipoABC.Multiline = true;
            this.txtTipoABC.Name = "txtTipoABC";
            this.txtTipoABC.Size = new System.Drawing.Size(245, 31);
            this.txtTipoABC.TabIndex = 1;
            // 
            // cmbNombreABC
            // 
            this.cmbNombreABC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreABC.FormattingEnabled = true;
            this.cmbNombreABC.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbNombreABC.Location = new System.Drawing.Point(208, 97);
            this.cmbNombreABC.Name = "cmbNombreABC";
            this.cmbNombreABC.Size = new System.Drawing.Size(78, 29);
            this.cmbNombreABC.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbEstado.Location = new System.Drawing.Point(208, 283);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(78, 29);
            this.cmbEstado.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(209, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 29);
            this.txtId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "&Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Tipo ABC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "&Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(208, 331);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 114);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "&Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Peso maximo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Peso minimo:";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            this.erroricono.Icon = ((System.Drawing.Icon)(resources.GetObject("erroricono.Icon")));
            // 
            // FrmABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmABC";
            this.Load += new System.EventHandler(this.FrmABC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpBusqueda.ResumeLayout(false);
            this.gpBusqueda.PerformLayout();
            this.gbopciones.ResumeLayout(false);
            this.gbopciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Vistas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpBusqueda;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbopciones;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCerrarvista;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView Datos_Vistas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.TextBox txtTipoABC;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesoMin;
        private System.Windows.Forms.ComboBox cmbNombreABC;
        private System.Windows.Forms.ErrorProvider erroricono;
    }
}