namespace MODULO_CEDIS
{
    partial class FrmPresentacionSpcreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnCargar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrCargando = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MODULO_CEDIS.Properties.Resources.Logo2_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(188, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.Color.Transparent;
            this.pnContenedor.Controls.Add(this.pnCargar);
            this.pnContenedor.Location = new System.Drawing.Point(0, 368);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(843, 24);
            this.pnContenedor.TabIndex = 1;
            // 
            // pnCargar
            // 
            this.pnCargar.BackColor = System.Drawing.Color.Green;
            this.pnCargar.Location = new System.Drawing.Point(3, 3);
            this.pnCargar.Name = "pnCargar";
            this.pnCargar.Size = new System.Drawing.Size(108, 20);
            this.pnCargar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Prohibida su venta, copia o distribución ilegal. Todos los derechos reservados 2" +
    "023. Versión 0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Cargando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Sistema CEDIS \"Centro de distribución\".";
            // 
            // tmrCargando
            // 
            this.tmrCargando.Enabled = true;
            this.tmrCargando.Tick += new System.EventHandler(this.tmrCargando_Tick);
            // 
            // FrmPresentacionSpcreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::MODULO_CEDIS.Properties.Resources._020035;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresentacionSpcreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnContenedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnCargar;
        private System.Windows.Forms.Timer tmrCargando;
    }
}