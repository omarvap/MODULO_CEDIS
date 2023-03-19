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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cargarsucursal();
        }
        public void cargarsucursal()
        {
            using (CEDISEntities cn = new CEDISEntities())
            {
                var lstsur = (from s in cn.sucursal
                              select s).ToList();

                cmbSur.DataSource = lstsur;
                cmbSur.ValueMember = "id";
                cmbSur.DisplayMember = "Nombre_sur";

                if (cmbSur == null)
                {
                    throw new ArgumentNullException(nameof(cmbSur));
                }


            }

        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            CEDISEntities cn = new CEDISEntities();

            string User = txtUser.Text;
            string Pass = txtPass.Text;
            int Sur = Convert.ToInt32(cmbSur.SelectedValue.ToString());

            var rec = cn.usuario.Where(a => a.Name_User == User && a.Pass == Pass && a.id_sur == Sur).FirstOrDefault();



            if (rec != null)
            {
                MessageBox.Show("Acceso Autorizado");
            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }

            this.Hide();
            FrmPresentacionSpcreen abrir = new FrmPresentacionSpcreen();
            abrir.FormClosed += Logout;
            abrir.FormClosed += (s, args) => this.Close();
            abrir.Show();
            
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CEDISEntities cn = new CEDISEntities();

                string User = txtUser.Text;
                string Pass = txtPass.Text;
                int Sur = Convert.ToInt32(cmbSur.SelectedValue.ToString());

                var rec = cn.usuario.Where(a => a.Name_User == User && a.Pass == Pass && a.id_sur == Sur).FirstOrDefault();



                if (rec != null)
                {
                    MessageBox.Show("Acceso Autorizado");
                }
                else
                {
                    MessageBox.Show("Acceso denegado");
                }

                this.Hide();
                FrmPresentacionSpcreen abrir = new FrmPresentacionSpcreen();
                abrir.FormClosed += Logout;
                abrir.FormClosed += (s, args) => this.Close();
                abrir.Show();
                
            }

        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Pass";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "Username";
            this.Show();
        }

    }
}
