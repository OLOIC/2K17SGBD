using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_SGBD_2017.Forms
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            lbInfo.Text = "Connecté en tant que Client : " + " PLACER NOM ICI";
        }
    }
}
