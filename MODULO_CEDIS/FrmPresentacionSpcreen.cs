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
    public partial class FrmPresentacionSpcreen : Form
    {
        public FrmPresentacionSpcreen()
        {
            InitializeComponent();
        }

        private void tmrCargando_Tick(object sender, EventArgs e)
        {
            pnCargar.Width += 3;

            if(pnCargar.Width >= 700)
            {
                tmrCargando.Stop();
                FrmMenu_Principal Fm = new FrmMenu_Principal();
                Fm.Show();
                this.Hide();
            }
        }
    }
}
