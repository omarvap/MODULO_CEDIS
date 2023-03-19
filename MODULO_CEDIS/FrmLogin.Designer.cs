namespace MODULO_CEDIS
{
    partial class FrmLogin
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.Button btnIngreso;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.cbLogin = new System.Windows.Forms.GroupBox();
            this.cmbSur = new System.Windows.Forms.ComboBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.cbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(85, 165);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "&Usuario";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(64, 241);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "&Contraseña";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Location = new System.Drawing.Point(77, 319);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "&Sucursal";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = global::MODULO_CEDIS.Properties.Resources.foto_login;
            pictureBox1.Location = new System.Drawing.Point(41, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(191, 132);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnIngreso
            // 
            btnIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            btnIngreso.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.cerrajero;
            btnIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnIngreso.FlatAppearance.BorderSize = 0;
            btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnIngreso.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            btnIngreso.Location = new System.Drawing.Point(90, 400);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new System.Drawing.Size(88, 41);
            btnIngreso.TabIndex = 3;
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // cbLogin
            // 
            this.cbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.cbLogin.Controls.Add(this.cmbSur);
            this.cbLogin.Controls.Add(this.txtPass);
            this.cbLogin.Controls.Add(this.txtUser);
            this.cbLogin.Controls.Add(pictureBox1);
            this.cbLogin.Controls.Add(btnIngreso);
            this.cbLogin.Controls.Add(label3);
            this.cbLogin.Controls.Add(label2);
            this.cbLogin.Controls.Add(label1);
            this.cbLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLogin.ForeColor = System.Drawing.Color.Black;
            this.cbLogin.Location = new System.Drawing.Point(12, 12);
            this.cbLogin.Name = "cbLogin";
            this.cbLogin.Size = new System.Drawing.Size(282, 487);
            this.cbLogin.TabIndex = 0;
            this.cbLogin.TabStop = false;
            this.cbLogin.Text = "Ingreso al sistema";
            // 
            // cmbSur
            // 
            this.cmbSur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSur.FormattingEnabled = true;
            this.cmbSur.Location = new System.Drawing.Point(73, 360);
            this.cmbSur.Name = "cmbSur";
            this.cmbSur.Size = new System.Drawing.Size(111, 30);
            this.cmbSur.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(32, 283);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(200, 25);
            this.txtPass.TabIndex = 5;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.txtUser.Location = new System.Drawing.Point(32, 193);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 25);
            this.txtUser.TabIndex = 5;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(306, 511);
            this.Controls.Add(this.cbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.cbLogin.ResumeLayout(false);
            this.cbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cbLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cmbSur;
    }
}