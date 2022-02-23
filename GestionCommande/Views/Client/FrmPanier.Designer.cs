
namespace Gestion_Commande.Views.Client
{
    partial class FrmPanier
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
            System.Windows.Forms.Panel panelPanierCmd;
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cboAdresse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLtotal = new System.Windows.Forms.Label();
            this.btn_DeleteCmd = new System.Windows.Forms.Button();
            this.btn_ValiderCdm = new System.Windows.Forms.Button();
            this.dtgvPanier = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            panelPanierCmd = new System.Windows.Forms.Panel();
            panelPanierCmd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPanier)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPanierCmd
            // 
            panelPanierCmd.BackColor = System.Drawing.Color.CadetBlue;
            panelPanierCmd.Controls.Add(this.txtAdresse);
            panelPanierCmd.Controls.Add(this.cboAdresse);
            panelPanierCmd.Controls.Add(this.label2);
            panelPanierCmd.Controls.Add(this.txtLtotal);
            panelPanierCmd.Controls.Add(this.btn_DeleteCmd);
            panelPanierCmd.Controls.Add(this.btn_ValiderCdm);
            panelPanierCmd.Controls.Add(this.dtgvPanier);
            panelPanierCmd.Controls.Add(this.label1);
            panelPanierCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            panelPanierCmd.Location = new System.Drawing.Point(0, 0);
            panelPanierCmd.Name = "panelPanierCmd";
            panelPanierCmd.Size = new System.Drawing.Size(750, 450);
            panelPanierCmd.TabIndex = 0;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(468, 282);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(133, 20);
            this.txtAdresse.TabIndex = 6;
            this.txtAdresse.Enter += new System.EventHandler(this.txtAdresse_Enter);
            // 
            // cboAdresse
            // 
            this.cboAdresse.BackColor = System.Drawing.Color.LightBlue;
            this.cboAdresse.FormattingEnabled = true;
            this.cboAdresse.Items.AddRange(new object[] {
            "MON ADRESSE",
            "AUTRE"});
            this.cboAdresse.Location = new System.Drawing.Point(312, 281);
            this.cboAdresse.Name = "cboAdresse";
            this.cboAdresse.Size = new System.Drawing.Size(121, 21);
            this.cboAdresse.TabIndex = 7;
            this.cboAdresse.Text = "Choix Adresse";
            this.cboAdresse.SelectionChangeCommitted += new System.EventHandler(this.cboAdresse_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Commandes: ";
            // 
            // txtLtotal
            // 
            this.txtLtotal.AutoSize = true;
            this.txtLtotal.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLtotal.Location = new System.Drawing.Point(162, 282);
            this.txtLtotal.Name = "txtLtotal";
            this.txtLtotal.Size = new System.Drawing.Size(32, 20);
            this.txtLtotal.TabIndex = 4;
            this.txtLtotal.Text = "prix ";
            // 
            // btn_DeleteCmd
            // 
            this.btn_DeleteCmd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_DeleteCmd.Location = new System.Drawing.Point(110, 345);
            this.btn_DeleteCmd.Name = "btn_DeleteCmd";
            this.btn_DeleteCmd.Size = new System.Drawing.Size(133, 43);
            this.btn_DeleteCmd.TabIndex = 3;
            this.btn_DeleteCmd.Text = "Annuler Commande";
            this.btn_DeleteCmd.UseVisualStyleBackColor = true;
            this.btn_DeleteCmd.Click += new System.EventHandler(this.btn_DeleteCmd_Click);
            // 
            // btn_ValiderCdm
            // 
            this.btn_ValiderCdm.Location = new System.Drawing.Point(444, 345);
            this.btn_ValiderCdm.Name = "btn_ValiderCdm";
            this.btn_ValiderCdm.Size = new System.Drawing.Size(133, 43);
            this.btn_ValiderCdm.TabIndex = 2;
            this.btn_ValiderCdm.Text = "Valider Panier";
            this.btn_ValiderCdm.UseVisualStyleBackColor = true;
            this.btn_ValiderCdm.Click += new System.EventHandler(this.btn_ValiderCdm_Click);
            // 
            // dtgvPanier
            // 
            this.dtgvPanier.AllowUserToOrderColumns = true;
            this.dtgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPanier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Libelle,
            this.pu,
            this.Quantite,
            this.Total,
            this.image});
            this.dtgvPanier.Enabled = false;
            this.dtgvPanier.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgvPanier.Location = new System.Drawing.Point(97, 99);
            this.dtgvPanier.MultiSelect = false;
            this.dtgvPanier.Name = "dtgvPanier";
            this.dtgvPanier.RowHeadersVisible = false;
            this.dtgvPanier.Size = new System.Drawing.Size(504, 162);
            this.dtgvPanier.TabIndex = 1;
            this.dtgvPanier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPanier_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            // 
            // pu
            // 
            this.pu.DataPropertyName = "pu";
            this.pu.HeaderText = "Prix unitaire";
            this.pu.Name = "pu";
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "qteCmd";
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.FillWeight = 200F;
            this.image.HeaderText = "image";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.Name = "image";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(288, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panier de commandes";
            // 
            // FrmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(panelPanierCmd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPanier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPanier";
            this.Load += new System.EventHandler(this.FrmPanier_Load);
            panelPanierCmd.ResumeLayout(false);
            panelPanierCmd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPanier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPanier;
        private System.Windows.Forms.Button btn_ValiderCdm;
        private System.Windows.Forms.Label txtLtotal;
        private System.Windows.Forms.Button btn_DeleteCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn pu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAdresse;
        private System.Windows.Forms.TextBox txtAdresse;
    }
}