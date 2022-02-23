
namespace GestionCommande.Views.RespoStock
{
    partial class FrmLivraison
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbListCmd = new System.Windows.Forms.GroupBox();
            this.gpbDetailsLivraison = new System.Windows.Forms.GroupBox();
            this.dtgvCmd = new System.Windows.Forms.DataGridView();
            this.IdCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvCmdLivraison = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.cboLivreur = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.gpbListCmd.SuspendLayout();
            this.gpbDetailsLivraison.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCmdLivraison)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.gpbDetailsLivraison);
            this.panel1.Controls.Add(this.gpbListCmd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 511);
            this.panel1.TabIndex = 0;
            // 
            // gpbListCmd
            // 
            this.gpbListCmd.BackColor = System.Drawing.Color.LightBlue;
            this.gpbListCmd.Controls.Add(this.btnAjouter);
            this.gpbListCmd.Controls.Add(this.dtgvCmd);
            this.gpbListCmd.Location = new System.Drawing.Point(30, 12);
            this.gpbListCmd.Name = "gpbListCmd";
            this.gpbListCmd.Size = new System.Drawing.Size(380, 470);
            this.gpbListCmd.TabIndex = 0;
            this.gpbListCmd.TabStop = false;
            this.gpbListCmd.Text = "Liste Commandes";
            // 
            // gpbDetailsLivraison
            // 
            this.gpbDetailsLivraison.BackColor = System.Drawing.Color.LightBlue;
            this.gpbDetailsLivraison.Controls.Add(this.cboLivreur);
            this.gpbDetailsLivraison.Controls.Add(this.btnValider);
            this.gpbDetailsLivraison.Controls.Add(this.dtgvCmdLivraison);
            this.gpbDetailsLivraison.Location = new System.Drawing.Point(450, 12);
            this.gpbDetailsLivraison.Name = "gpbDetailsLivraison";
            this.gpbDetailsLivraison.Size = new System.Drawing.Size(395, 470);
            this.gpbDetailsLivraison.TabIndex = 1;
            this.gpbDetailsLivraison.TabStop = false;
            this.gpbDetailsLivraison.Text = "Details Livraison";
            // 
            // dtgvCmd
            // 
            this.dtgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCmd,
            this.nomClient,
            this.statut,
            this.date});
            this.dtgvCmd.Location = new System.Drawing.Point(23, 80);
            this.dtgvCmd.Name = "dtgvCmd";
            this.dtgvCmd.RowHeadersVisible = false;
            this.dtgvCmd.Size = new System.Drawing.Size(334, 150);
            this.dtgvCmd.TabIndex = 1;
            this.dtgvCmd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCmd_CellClick);
            // 
            // IdCmd
            // 
            this.IdCmd.DataPropertyName = "id";
            this.IdCmd.HeaderText = "Id";
            this.IdCmd.Name = "IdCmd";
            this.IdCmd.Width = 30;
            // 
            // nomClient
            // 
            this.nomClient.DataPropertyName = "nomClient";
            this.nomClient.HeaderText = "Nom Client";
            this.nomClient.Name = "nomClient";
            this.nomClient.Width = 110;
            // 
            // statut
            // 
            this.statut.DataPropertyName = "statut";
            this.statut.HeaderText = "statut";
            this.statut.Name = "statut";
            this.statut.Width = 85;
            // 
            // date
            // 
            this.date.DataPropertyName = "dateCmd";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Width = 110;
            // 
            // dtgvCmdLivraison
            // 
            this.dtgvCmdLivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCmdLivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgvCmdLivraison.Location = new System.Drawing.Point(31, 80);
            this.dtgvCmdLivraison.Name = "dtgvCmdLivraison";
            this.dtgvCmdLivraison.RowHeadersVisible = false;
            this.dtgvCmdLivraison.Size = new System.Drawing.Size(334, 150);
            this.dtgvCmdLivraison.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom Client";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "statut";
            this.dataGridViewTextBoxColumn3.HeaderText = "statut";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateCmd";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(224, 295);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(120, 31);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter à la livraison";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(245, 295);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(120, 31);
            this.btnValider.TabIndex = 3;
            this.btnValider.Text = "Valider Livraison";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // cboLivreur
            // 
            this.cboLivreur.FormattingEnabled = true;
            this.cboLivreur.Location = new System.Drawing.Point(31, 295);
            this.cboLivreur.Name = "cboLivreur";
            this.cboLivreur.Size = new System.Drawing.Size(121, 21);
            this.cboLivreur.TabIndex = 4;
            this.cboLivreur.Text = "Livreur";
            // 
            // FrmLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 511);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLivraison";
            this.Text = "FrmLivraison";
            this.Load += new System.EventHandler(this.FrmLivraison_Load);
            this.panel1.ResumeLayout(false);
            this.gpbListCmd.ResumeLayout(false);
            this.gpbDetailsLivraison.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCmdLivraison)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbDetailsLivraison;
        private System.Windows.Forms.GroupBox gpbListCmd;
        private System.Windows.Forms.DataGridView dtgvCmdLivraison;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dtgvCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ComboBox cboLivreur;
        private System.Windows.Forms.Button btnValider;
    }
}