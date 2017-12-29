namespace Examen_SGBD_2017.Forms
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.pnLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitre = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btDeconnexion = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pnLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLayout
            // 
            this.pnLayout.Controls.Add(this.panel1);
            this.pnLayout.Controls.Add(this.flowLayoutPanel1);
            this.pnLayout.Controls.Add(this.btDeconnexion);
            this.pnLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnLayout.Name = "pnLayout";
            this.pnLayout.Size = new System.Drawing.Size(271, 744);
            this.pnLayout.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lbTitre);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 150);
            this.panel1.TabIndex = 0;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Palatino Linotype", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.White;
            this.lbTitre.Location = new System.Drawing.Point(35, 29);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(279, 140);
            this.lbTitre.TabIndex = 0;
            this.lbTitre.Text = "   EPHEC\r\nAIRLINES\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 159);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 76);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btDeconnexion
            // 
            this.btDeconnexion.FlatAppearance.BorderSize = 0;
            this.btDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btDeconnexion.Image = ((System.Drawing.Image)(resources.GetObject("btDeconnexion.Image")));
            this.btDeconnexion.Location = new System.Drawing.Point(3, 241);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(268, 124);
            this.btDeconnexion.TabIndex = 10;
            this.btDeconnexion.Text = "Deconnexion";
            this.btDeconnexion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDeconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDeconnexion.UseVisualStyleBackColor = true;
            this.btDeconnexion.Click += new System.EventHandler(this.btDeconnexion_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(482, 77);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(579, 45);
            this.lbInfo.TabIndex = 9;
            this.lbInfo.Text = "Connecté en tant qu\'Administrateur";
            // 
            // frmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1124, 744);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pnLayout);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.pnLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btDeconnexion;
        private System.Windows.Forms.Label lbInfo;
    }
}