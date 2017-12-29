namespace Examen_SGBD_2017
{
    partial class Connexion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbConnexion = new System.Windows.Forms.Label();
            this.btAdministration = new System.Windows.Forms.Button();
            this.btClient = new System.Windows.Forms.Button();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.btConCombo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConnexion
            // 
            this.lbConnexion.AutoSize = true;
            this.lbConnexion.Font = new System.Drawing.Font("Comic Sans MS", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnexion.Location = new System.Drawing.Point(327, 171);
            this.lbConnexion.Name = "lbConnexion";
            this.lbConnexion.Size = new System.Drawing.Size(223, 45);
            this.lbConnexion.TabIndex = 0;
            this.lbConnexion.Text = "Se connecter";
            // 
            // btAdministration
            // 
            this.btAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdministration.Location = new System.Drawing.Point(178, 297);
            this.btAdministration.Name = "btAdministration";
            this.btAdministration.Size = new System.Drawing.Size(457, 67);
            this.btAdministration.TabIndex = 1;
            this.btAdministration.Text = "Administrateur";
            this.btAdministration.UseVisualStyleBackColor = true;
            this.btAdministration.Click += new System.EventHandler(this.btAdministration_Click);
            // 
            // btClient
            // 
            this.btClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClient.Location = new System.Drawing.Point(178, 411);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(457, 67);
            this.btClient.TabIndex = 2;
            this.btClient.Text = "Client";
            this.btClient.UseVisualStyleBackColor = true;
            this.btClient.Click += new System.EventHandler(this.btClient_Click);
            // 
            // comboClient
            // 
            this.comboClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.comboClient.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Items.AddRange(new object[] {
            "  Choisissez votre identifiant :",
            "a",
            "b",
            "c"});
            this.comboClient.Location = new System.Drawing.Point(178, 524);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(256, 31);
            this.comboClient.TabIndex = 3;
            this.comboClient.Visible = false;
            this.comboClient.SelectedIndexChanged += new System.EventHandler(this.comboClient_SelectedIndexChanged);
            // 
            // btConCombo
            // 
            this.btConCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConCombo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConCombo.Location = new System.Drawing.Point(467, 518);
            this.btConCombo.Name = "btConCombo";
            this.btConCombo.Size = new System.Drawing.Size(168, 36);
            this.btConCombo.TabIndex = 4;
            this.btConCombo.Text = "Connexion";
            this.btConCombo.UseVisualStyleBackColor = true;
            this.btConCombo.Visible = false;
            this.btConCombo.Click += new System.EventHandler(this.btConCombo_Click);
            // 
            // Connexion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btConCombo);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.btClient);
            this.Controls.Add(this.btAdministration);
            this.Controls.Add(this.lbConnexion);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Connexion";
            this.Size = new System.Drawing.Size(831, 741);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConnexion;
        private System.Windows.Forms.Button btAdministration;
        private System.Windows.Forms.Button btClient;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Button btConCombo;
    }
}
