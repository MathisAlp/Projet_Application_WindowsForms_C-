
namespace GestionCommande.Views.Secretaire
{
    partial class FrmMenuSecretaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuSecretaire));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbDetails = new System.Windows.Forms.GroupBox();
            this.txtAdresse = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAttente = new System.Windows.Forms.Button();
            this.dtgvDetailsCmd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCmd = new System.Windows.Forms.DataGridView();
            this.IdCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.txtLrole = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gpbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailsCmd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCmd)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.gpbDetails);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 521);
            this.panel1.TabIndex = 0;
            // 
            // gpbDetails
            // 
            this.gpbDetails.BackColor = System.Drawing.Color.LightBlue;
            this.gpbDetails.Controls.Add(this.txtAdresse);
            this.gpbDetails.Controls.Add(this.txtTotal);
            this.gpbDetails.Controls.Add(this.btnValider);
            this.gpbDetails.Controls.Add(this.btnAttente);
            this.gpbDetails.Controls.Add(this.dtgvDetailsCmd);
            this.gpbDetails.Location = new System.Drawing.Point(618, 22);
            this.gpbDetails.Name = "gpbDetails";
            this.gpbDetails.Size = new System.Drawing.Size(507, 462);
            this.gpbDetails.TabIndex = 2;
            this.gpbDetails.TabStop = false;
            this.gpbDetails.Text = "Détails commandes";
            // 
            // txtAdresse
            // 
            this.txtAdresse.AutoSize = true;
            this.txtAdresse.Location = new System.Drawing.Point(68, 299);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(96, 13);
            this.txtAdresse.TabIndex = 7;
            this.txtAdresse.Text = "Adresse Livraison: ";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(68, 251);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 13);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "Total Commande: ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(324, 370);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(106, 30);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAttente
            // 
            this.btnAttente.Location = new System.Drawing.Point(68, 370);
            this.btnAttente.Name = "btnAttente";
            this.btnAttente.Size = new System.Drawing.Size(106, 30);
            this.btnAttente.TabIndex = 5;
            this.btnAttente.Text = "Mettre en attente";
            this.btnAttente.UseVisualStyleBackColor = true;
            this.btnAttente.Click += new System.EventHandler(this.btnAttente_Click);
            // 
            // dtgvDetailsCmd
            // 
            this.dtgvDetailsCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetailsCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.libelle,
            this.quantite,
            this.prixUnitaire,
            this.Total,
            this.qteStock});
            this.dtgvDetailsCmd.Location = new System.Drawing.Point(6, 73);
            this.dtgvDetailsCmd.Name = "dtgvDetailsCmd";
            this.dtgvDetailsCmd.RowHeadersVisible = false;
            this.dtgvDetailsCmd.Size = new System.Drawing.Size(484, 150);
            this.dtgvDetailsCmd.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // libelle
            // 
            this.libelle.DataPropertyName = "libelle";
            this.libelle.HeaderText = "Libelle";
            this.libelle.Name = "libelle";
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "qteCmd";
            this.quantite.HeaderText = "Quantite";
            this.quantite.Name = "quantite";
            this.quantite.Width = 75;
            // 
            // prixUnitaire
            // 
            this.prixUnitaire.DataPropertyName = "pu";
            this.prixUnitaire.HeaderText = "Prix Unitaire (FCFA)";
            this.prixUnitaire.Name = "prixUnitaire";
            this.prixUnitaire.Width = 125;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 75;
            // 
            // qteStock
            // 
            this.qteStock.DataPropertyName = "qteStock";
            this.qteStock.HeaderText = "Quantité Stock";
            this.qteStock.Name = "qteStock";
            this.qteStock.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.dtgvCmd);
            this.groupBox1.Location = new System.Drawing.Point(231, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 462);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste commandes";
            // 
            // dtgvCmd
            // 
            this.dtgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCmd,
            this.nomClient,
            this.statut,
            this.date});
            this.dtgvCmd.Location = new System.Drawing.Point(13, 73);
            this.dtgvCmd.Name = "dtgvCmd";
            this.dtgvCmd.RowHeadersVisible = false;
            this.dtgvCmd.Size = new System.Drawing.Size(334, 150);
            this.dtgvCmd.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeconnexion);
            this.panel2.Controls.Add(this.txtLrole);
            this.panel2.Controls.Add(this.txtLname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 521);
            this.panel2.TabIndex = 0;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(20, 453);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(106, 30);
            this.btnDeconnexion.TabIndex = 3;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // txtLrole
            // 
            this.txtLrole.AutoSize = true;
            this.txtLrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLrole.Location = new System.Drawing.Point(20, 219);
            this.txtLrole.Name = "txtLrole";
            this.txtLrole.Size = new System.Drawing.Size(43, 16);
            this.txtLrole.TabIndex = 2;
            this.txtLrole.Text = "Role: ";
            // 
            // txtLname
            // 
            this.txtLname.AutoSize = true;
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(20, 189);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(78, 16);
            this.txtLname.TabIndex = 1;
            this.txtLname.Text = "Bienvenue, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuSecretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 521);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenuSecretaire";
            this.Text = "FrmMenuSecretaire";
            this.Load += new System.EventHandler(this.FrmMenuSecretaire_Load);
            this.panel1.ResumeLayout(false);
            this.gpbDetails.ResumeLayout(false);
            this.gpbDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetailsCmd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCmd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Label txtLrole;
        private System.Windows.Forms.Label txtLname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbDetails;
        private System.Windows.Forms.DataGridView dtgvCmd;
        private System.Windows.Forms.DataGridView dtgvDetailsCmd;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAttente;
        private System.Windows.Forms.Label txtAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}