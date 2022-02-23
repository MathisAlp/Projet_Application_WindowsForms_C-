
namespace GestionCommande.Views.Client
{
    partial class FrmCatalogue
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
            this.components = new System.ComponentModel.Container();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_gestionCmdDataSet = new GestionCommande.db_gestionCmdDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneDetails = new System.Windows.Forms.Panel();
            this.txtTotalForPanier = new System.Windows.Forms.TextBox();
            this.txtQteSaisie = new System.Windows.Forms.TextBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btnAddPanier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.Label();
            this.txtLDescription = new System.Windows.Forms.Label();
            this.pctProduit = new System.Windows.Forms.PictureBox();
            this.produitTableAdapter = new GestionCommande.db_gestionCmdDataSetTableAdapters.ProduitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_gestionCmdDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.paneDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduit
            // 
            this.dgvProduit.AllowUserToAddRows = false;
            this.dgvProduit.AllowUserToDeleteRows = false;
            this.dgvProduit.AutoGenerateColumns = false;
            this.dgvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libelle,
            this.Prix,
            this.Image,
            this.id});
            this.dgvProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProduit.DataSource = this.produitBindingSource;
            this.dgvProduit.Location = new System.Drawing.Point(38, 49);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.ReadOnly = true;
            this.dgvProduit.RowHeadersVisible = false;
            this.dgvProduit.Size = new System.Drawing.Size(658, 194);
            this.dgvProduit.TabIndex = 0;
            this.dgvProduit.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduit_CellMouseClick);
            // 
            // Libelle
            // 
            this.Libelle.DataPropertyName = "libelle";
            this.Libelle.HeaderText = "Libellé";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.DataPropertyName = "prixUnitaire";
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.DataPropertyName = "img";
            this.Image.FillWeight = 200F;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id
            // 
            this.id.DataPropertyName = "idProduit";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.db_gestionCmdDataSet;
            // 
            // db_gestionCmdDataSet
            // 
            this.db_gestionCmdDataSet.DataSetName = "db_gestionCmdDataSet";
            this.db_gestionCmdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalogue de produits";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paneDetails);
            this.panel1.Controls.Add(this.dgvProduit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 520);
            this.panel1.TabIndex = 3;
            // 
            // paneDetails
            // 
            this.paneDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.paneDetails.Controls.Add(this.txtTotalForPanier);
            this.paneDetails.Controls.Add(this.txtQteSaisie);
            this.paneDetails.Controls.Add(this.btn_Annuler);
            this.paneDetails.Controls.Add(this.btnAddPanier);
            this.paneDetails.Controls.Add(this.label2);
            this.paneDetails.Controls.Add(this.label3);
            this.paneDetails.Controls.Add(this.txtPrix);
            this.paneDetails.Controls.Add(this.txtLDescription);
            this.paneDetails.Controls.Add(this.pctProduit);
            this.paneDetails.Location = new System.Drawing.Point(38, 271);
            this.paneDetails.Name = "paneDetails";
            this.paneDetails.Size = new System.Drawing.Size(658, 224);
            this.paneDetails.TabIndex = 5;
            this.paneDetails.Visible = false;
            // 
            // txtTotalForPanier
            // 
            this.txtTotalForPanier.AccessibleName = "";
            this.txtTotalForPanier.Location = new System.Drawing.Point(494, 126);
            this.txtTotalForPanier.Name = "txtTotalForPanier";
            this.txtTotalForPanier.Size = new System.Drawing.Size(110, 20);
            this.txtTotalForPanier.TabIndex = 9;
            // 
            // txtQteSaisie
            // 
            this.txtQteSaisie.AccessibleName = "";
            this.txtQteSaisie.Location = new System.Drawing.Point(494, 60);
            this.txtQteSaisie.Name = "txtQteSaisie";
            this.txtQteSaisie.Size = new System.Drawing.Size(110, 20);
            this.txtQteSaisie.TabIndex = 8;
            this.txtQteSaisie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQteSaisie_KeyUp);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(400, 169);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(123, 30);
            this.btn_Annuler.TabIndex = 7;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            // 
            // btnAddPanier
            // 
            this.btnAddPanier.Location = new System.Drawing.Point(224, 169);
            this.btnAddPanier.Name = "btnAddPanier";
            this.btnAddPanier.Size = new System.Drawing.Size(123, 30);
            this.btnAddPanier.TabIndex = 6;
            this.btnAddPanier.Text = "Ajouter au Panier";
            this.btnAddPanier.UseVisualStyleBackColor = true;
            this.btnAddPanier.Click += new System.EventHandler(this.btnAddPanier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantité";
            // 
            // txtPrix
            // 
            this.txtPrix.AutoSize = true;
            this.txtPrix.Location = new System.Drawing.Point(221, 123);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(30, 13);
            this.txtPrix.TabIndex = 2;
            this.txtPrix.Text = "Prix: ";
            // 
            // txtLDescription
            // 
            this.txtLDescription.Location = new System.Drawing.Point(221, 57);
            this.txtLDescription.Name = "txtLDescription";
            this.txtLDescription.Size = new System.Drawing.Size(172, 46);
            this.txtLDescription.TabIndex = 1;
            this.txtLDescription.Text = "Description: ";
            // 
            // pctProduit
            // 
            this.pctProduit.Location = new System.Drawing.Point(36, 38);
            this.pctProduit.Name = "pctProduit";
            this.pctProduit.Size = new System.Drawing.Size(141, 144);
            this.pctProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctProduit.TabIndex = 0;
            this.pctProduit.TabStop = false;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCatalogue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(750, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCatalogue";
            this.Load += new System.EventHandler(this.FrmCatalogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_gestionCmdDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.paneDetails.ResumeLayout(false);
            this.paneDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btnAddPanier;
        private System.Windows.Forms.Panel paneDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtPrix;
        private System.Windows.Forms.Label txtLDescription;
        private System.Windows.Forms.PictureBox pctProduit;
        private System.Windows.Forms.Button btn_Annuler;
        private db_gestionCmdDataSet db_gestionCmdDataSet;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private db_gestionCmdDataSetTableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.TextBox txtTotalForPanier;
        private System.Windows.Forms.TextBox txtQteSaisie;
    }
}