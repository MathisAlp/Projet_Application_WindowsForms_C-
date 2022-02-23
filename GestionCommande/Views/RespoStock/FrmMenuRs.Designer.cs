
namespace GestionCommande.Views.RespoStock
{
    partial class FrmMenuRs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuRs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLRole = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFormLivraison = new System.Windows.Forms.Button();
            this.btnFormProduit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.txtLRole);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnFormLivraison);
            this.panel1.Controls.Add(this.btnFormProduit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 566);
            this.panel1.TabIndex = 1;
            // 
            // txtLRole
            // 
            this.txtLRole.AutoSize = true;
            this.txtLRole.Location = new System.Drawing.Point(37, 200);
            this.txtLRole.Name = "txtLRole";
            this.txtLRole.Size = new System.Drawing.Size(38, 13);
            this.txtLRole.TabIndex = 5;
            this.txtLRole.Text = "Role : ";
            // 
            // txtLname
            // 
            this.txtLname.AutoSize = true;
            this.txtLname.Location = new System.Drawing.Point(37, 167);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(64, 13);
            this.txtLname.TabIndex = 4;
            this.txtLname.Text = "Bienvenue, ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Deconnexion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFormLivraison
            // 
            this.btnFormLivraison.Location = new System.Drawing.Point(37, 353);
            this.btnFormLivraison.Name = "btnFormLivraison";
            this.btnFormLivraison.Size = new System.Drawing.Size(157, 43);
            this.btnFormLivraison.TabIndex = 2;
            this.btnFormLivraison.Text = "Planifier Livraison";
            this.btnFormLivraison.UseVisualStyleBackColor = true;
            this.btnFormLivraison.Click += new System.EventHandler(this.btnFormLivraison_Click);
            // 
            // btnFormProduit
            // 
            this.btnFormProduit.Location = new System.Drawing.Point(37, 272);
            this.btnFormProduit.Name = "btnFormProduit";
            this.btnFormProduit.Size = new System.Drawing.Size(157, 43);
            this.btnFormProduit.TabIndex = 1;
            this.btnFormProduit.Text = "Gerer produit";
            this.btnFormProduit.UseVisualStyleBackColor = true;
            this.btnFormProduit.Click += new System.EventHandler(this.btnFormProduit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuRs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 566);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenuRs";
            this.Text = "FrmMenuRs";
            this.Load += new System.EventHandler(this.FrmMenuRs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFormLivraison;
        private System.Windows.Forms.Button btnFormProduit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtLRole;
        private System.Windows.Forms.Label txtLname;
    }
}