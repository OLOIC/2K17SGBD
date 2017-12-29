namespace Examen_SGBD_2017
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitre = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btHome = new System.Windows.Forms.Button();
            this.btConnexion = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lbEphec = new System.Windows.Forms.Label();
            this.pcbAvion = new System.Windows.Forms.PictureBox();
            this.pnlConnexion = new Examen_SGBD_2017.Connexion();
            this.pnLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLayout
            // 
            this.pnLayout.Controls.Add(this.panel1);
            this.pnLayout.Controls.Add(this.flowLayoutPanel1);
            this.pnLayout.Controls.Add(this.btHome);
            this.pnLayout.Controls.Add(this.btConnexion);
            this.pnLayout.Controls.Add(this.btQuitter);
            this.pnLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLayout.Location = new System.Drawing.Point(0, 0);
            this.pnLayout.Name = "pnLayout";
            this.pnLayout.Size = new System.Drawing.Size(271, 744);
            this.pnLayout.TabIndex = 7;
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
            // btHome
            // 
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = ((System.Drawing.Image)(resources.GetObject("btHome.Image")));
            this.btHome.Location = new System.Drawing.Point(3, 241);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(268, 124);
            this.btHome.TabIndex = 8;
            this.btHome.Text = "Home";
            this.btHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btConnexion
            // 
            this.btConnexion.FlatAppearance.BorderSize = 0;
            this.btConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnexion.ForeColor = System.Drawing.Color.White;
            this.btConnexion.Image = ((System.Drawing.Image)(resources.GetObject("btConnexion.Image")));
            this.btConnexion.Location = new System.Drawing.Point(3, 371);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(268, 124);
            this.btConnexion.TabIndex = 10;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.FlatAppearance.BorderSize = 0;
            this.btQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuitter.ForeColor = System.Drawing.Color.White;
            this.btQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btQuitter.Image")));
            this.btQuitter.Location = new System.Drawing.Point(3, 501);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(268, 124);
            this.btQuitter.TabIndex = 11;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.pnLeft.Location = new System.Drawing.Point(277, 244);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(7, 124);
            this.pnLeft.TabIndex = 8;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlConnexion);
            this.pnlBody.Controls.Add(this.lbEphec);
            this.pnlBody.Controls.Add(this.pcbAvion);
            this.pnlBody.Location = new System.Drawing.Point(290, 3);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(831, 741);
            this.pnlBody.TabIndex = 9;
            // 
            // lbEphec
            // 
            this.lbEphec.AutoSize = true;
            this.lbEphec.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEphec.Location = new System.Drawing.Point(183, 538);
            this.lbEphec.Name = "lbEphec";
            this.lbEphec.Size = new System.Drawing.Size(725, 45);
            this.lbEphec.TabIndex = 1;
            this.lbEphec.Text = "EPHEC AIRLINES vous souhaite la bienvenue";
            // 
            // pcbAvion
            // 
            this.pcbAvion.Image = global::Examen_SGBD_2017.Properties.Resources.Avion;
            this.pcbAvion.Location = new System.Drawing.Point(91, 76);
            this.pcbAvion.Name = "pcbAvion";
            this.pcbAvion.Size = new System.Drawing.Size(676, 368);
            this.pcbAvion.TabIndex = 0;
            this.pcbAvion.TabStop = false;
            // 
            // pnlConnexion
            // 
            this.pnlConnexion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConnexion.Location = new System.Drawing.Point(0, 0);
            this.pnlConnexion.Name = "pnlConnexion";
            this.pnlConnexion.Size = new System.Drawing.Size(831, 741);
            this.pnlConnexion.TabIndex = 2;
            this.pnlConnexion.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1124, 744);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnLayout);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPHEC AIRLINES";
            this.pnLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAvion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.PictureBox pcbAvion;
        private System.Windows.Forms.Label lbEphec;
        private Connexion pnlConnexion;
    }
}