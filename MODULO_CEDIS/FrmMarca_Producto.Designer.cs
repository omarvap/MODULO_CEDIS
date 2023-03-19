namespace MODULO_CEDIS
{
    partial class FrmMarca_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca_Producto));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrarVista = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Datos_Vistas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbContenedor = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Vistas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbOpciones.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox1);
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
            this.gpBusqueda.Controls.Add(this.txtbuscar);
            this.gpBusqueda.Controls.Add(this.btnBuscar);
            this.gpBusqueda.Controls.Add(this.label10);
            this.gpBusqueda.Controls.Add(this.label12);
            this.gpBusqueda.Controls.Add(this.label13);
            this.gpBusqueda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBusqueda.Location = new System.Drawing.Point(6, 6);
            this.gpBusqueda.Name = "gpBusqueda";
            this.gpBusqueda.Size = new System.Drawing.Size(702, 106);
            this.gpBusqueda.TabIndex = 11;
            this.gpBusqueda.TabStop = false;
            this.gpBusqueda.Text = "&Busqueda";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(60, 61);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(310, 32);
            this.txtbuscar.TabIndex = 3;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(-293, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "&Buscar";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(17, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Busqueda por:";
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
            this.label13.Location = new System.Drawing.Point(593, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "&Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnCerrarVista);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(580, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 245);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Opciones";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(36, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 38);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCerrarVista
            // 
            this.btnCerrarVista.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarVista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarVista.BackgroundImage")));
            this.btnCerrarVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarVista.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCerrarVista.FlatAppearance.BorderSize = 0;
            this.btnCerrarVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVista.Location = new System.Drawing.Point(38, 131);
            this.btnCerrarVista.Name = "btnCerrarVista";
            this.btnCerrarVista.Size = new System.Drawing.Size(47, 47);
            this.btnCerrarVista.TabIndex = 4;
            this.btnCerrarVista.UseVisualStyleBackColor = false;
            this.btnCerrarVista.Click += new System.EventHandler(this.btnCerrarVista_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(18, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 26);
            this.label14.TabIndex = 6;
            this.label14.Text = "Cerrar";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(11, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 26);
            this.label15.TabIndex = 6;
            this.label15.Text = "Reporte";
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
            this.Datos_Vistas.Location = new System.Drawing.Point(6, 149);
            this.Datos_Vistas.Name = "Datos_Vistas";
            this.Datos_Vistas.Size = new System.Drawing.Size(552, 340);
            this.Datos_Vistas.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.gbOpciones);
            this.tabPage2.Controls.Add(this.gbContenedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.label2);
            this.gbOpciones.Controls.Add(this.btnEliminar);
            this.gbOpciones.Controls.Add(this.label9);
            this.gbOpciones.Controls.Add(this.label8);
            this.gbOpciones.Controls.Add(this.label7);
            this.gbOpciones.Controls.Add(this.label6);
            this.gbOpciones.Controls.Add(this.btnCerrar);
            this.gbOpciones.Controls.Add(this.btnEditar);
            this.gbOpciones.Controls.Add(this.btnGuardar);
            this.gbOpciones.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(543, 72);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(134, 350);
            this.gbOpciones.TabIndex = 7;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "&Cerrar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "&Editar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "&Guardar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "&Guardar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(37, 270);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(55, 45);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(37, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 45);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.disquete;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(37, 47);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(55, 32);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.txtId);
            this.gbContenedor.Controls.Add(this.txtNomMarca);
            this.gbContenedor.Controls.Add(this.label3);
            this.gbContenedor.Controls.Add(this.label1);
            this.gbContenedor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(49, 72);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(450, 335);
            this.gbContenedor.TabIndex = 6;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "&Ingreso de datos";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(214, 128);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 24);
            this.txtId.TabIndex = 1;
            // 
            // txtNomMarca
            // 
            this.txtNomMarca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMarca.Location = new System.Drawing.Point(214, 176);
            this.txtNomMarca.Multiline = true;
            this.txtNomMarca.Name = "txtNomMarca";
            this.txtNomMarca.Size = new System.Drawing.Size(212, 31);
            this.txtNomMarca.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Nombre marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Codigo:";
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            this.erroricono.Icon = ((System.Drawing.Icon)(resources.GetObject("erroricono.Icon")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "&Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.boton_eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(37, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 49);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmMarca_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMarca_Producto";
            this.Load += new System.EventHandler(this.FrmMarca_Producto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpBusqueda.ResumeLayout(false);
            this.gpBusqueda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Vistas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.gbContenedor.ResumeLayout(false);
            this.gbContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gpBusqueda;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrarVista;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Datos_Vistas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbContenedor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
    }
}