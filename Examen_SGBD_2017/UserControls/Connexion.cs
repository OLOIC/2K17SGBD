using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen_SGBD_2017.Forms;

namespace Examen_SGBD_2017
{
    public partial class Connexion : UserControl
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btAdministration_Click(object sender, EventArgs e)
        {
            frmAdmin Admin = new frmAdmin();
            Admin.Show();
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            comboClient.Visible = true;
            comboClient.SelectedIndex = 0;
        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboClient.Text == "  Choisissez votre identifiant :")
            {
                btConCombo.Visible = false;
            }
            else
            btConCombo.Visible = true;
        }

        private void btConCombo_Click(object sender, EventArgs e)
        {
                frmClient Client = new frmClient();
                Client.Show();
                comboClient.SelectedIndex = 0;
                btConCombo.Visible = false;
                comboClient.Visible = false;
            
        }
    }
}
