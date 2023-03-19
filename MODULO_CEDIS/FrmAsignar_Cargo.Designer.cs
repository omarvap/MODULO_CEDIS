namespace MODULO_CEDIS
{
    partial class FrmAsignar_Cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignar_Cargo));
            this.erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpBusqueda = new System.Windows.Forms.GroupBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCerrarvista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpBusqueda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Vistas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.gbContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // erroricono
            // 
            this.erroricono.ContainerControl = this;
            this.erroricono.Icon = ((System.Drawing.Icon)(resources.GetObject("erroricono.Icon")));
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(721, 536);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(713, 504);
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
            this.gpBusqueda.Controls.Add(this.label4);
            this.gpBusqueda.Controls.Add(this.label10);
            this.gpBusqueda.Controls.Add(this.label11);
            this.gpBusqueda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBusqueda.Location = new System.Drawing.Point(23, 6);
            this.gpBusqueda.Name = "gpBusqueda";
            this.gpBusqueda.Size = new System.Drawing.Size(684, 114);
            this.gpBusqueda.TabIndex = 14;
            this.gpBusqueda.TabStop = false;
            this.gpBusqueda.Text = "&Busqueda";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(35, 62);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(296, 32);
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
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(-293, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Buscar";
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
            this.label10.Location = new System.Drawing.Point(17, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Busqueda por:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(593, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "&Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnCerrarvista);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(558, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 204);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Opciones";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(35, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "&Cerrar";
            // 
            // btnCerrarvista
            // 
            this.btnCerrarvista.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.cerrar;
            this.btnCerrarvista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarvista.FlatAppearance.BorderSize = 0;
            this.btnCerrarvista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarvista.Location = new System.Drawing.Point(40, 112);
            this.btnCerrarvista.Name = "btnCerrarvista";
            this.btnCerrarvista.Size = new System.Drawing.Size(55, 45);
            this.btnCerrarvista.TabIndex = 7;
            this.btnCerrarvista.UseVisualStyleBackColor = true;
            this.btnCerrarvista.Click += new System.EventHandler(this.btnCerrarvista_Click);
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
            this.button1.Location = new System.Drawing.Point(40, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 38);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 26);
            this.label12.TabIndex = 6;
            this.label12.Text = "Reporte";
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
            this.Datos_Vistas.Location = new System.Drawing.Point(23, 147);
            this.Datos_Vistas.Name = "Datos_Vistas";
            this.Datos_Vistas.Size = new System.Drawing.Size(529, 279);
            this.Datos_Vistas.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.gbOpciones);
            this.tabPage2.Controls.Add(this.gbContenedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(713, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.label9);
            this.gbOpciones.Controls.Add(this.label8);
            this.gbOpciones.Controls.Add(this.label7);
            this.gbOpciones.Controls.Add(this.label6);
            this.gbOpciones.Controls.Add(this.btnCerrar);
            this.gbOpciones.Controls.Add(this.btnEditar);
            this.gbOpciones.Controls.Add(this.btnGuardar);
            this.gbOpciones.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(531, 110);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(134, 294);
            this.gbOpciones.TabIndex = 9;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(32, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "&Cerrar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(32, 168);
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
            this.btnCerrar.Location = new System.Drawing.Point(37, 199);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(55, 45);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // gbContenedor
            // 
            this.gbContenedor.Controls.Add(this.txtId);
            this.gbContenedor.Controls.Add(this.label3);
            this.gbContenedor.Controls.Add(this.label2);
            this.gbContenedor.Controls.Add(this.label1);
            this.gbContenedor.Controls.Add(this.cmbCargo);
            this.gbContenedor.Controls.Add(this.cmbEmpleado);
            this.gbContenedor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedor.Location = new System.Drawing.Point(48, 69);
            this.gbContenedor.Name = "gbContenedor";
            this.gbContenedor.Size = new System.Drawing.Size(450, 366);
            this.gbContenedor.TabIndex = 8;
            this.gbContenedor.TabStop = false;
            this.gbContenedor.Text = "&Ingreso de datos";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(180, 96);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(114, 24);
            this.txtId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Seleccón:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Selección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Codigo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(180, 178);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(212, 29);
            this.cmbCargo.TabIndex = 2;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(180, 135);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(212, 29);
            this.cmbEmpleado.TabIndex = 2;
            // 
            // FrmAsignar_Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 561);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAsignar_Cargo";
            this.Load += new System.EventHandler(this.FrmAsignar_Cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroricono)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erroricono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.GroupBox gpBusqueda;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCerrarvista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView Datos_Vistas;
    }
}