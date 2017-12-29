using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_SGBD_2017
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            pnLeft.Height = btHome.Height;
            pnLeft.Top = btHome.Top;
            pnlConnexion.Visible = false;
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            pnLeft.Height = btConnexion.Height;
            pnLeft.Top = btConnexion.Top;
            pnlConnexion.Visible = true;
        }
    }
}
