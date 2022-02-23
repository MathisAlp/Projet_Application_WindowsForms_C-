
namespace Gestion_Commande.Views.Client
{
    partial class FrmMenuClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLRefCpt = new System.Windows.Forms.Label();
            this.txtLAdresse = new System.Windows.Forms.Label();
            this.txtLsolde = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnPanier = new System.Windows.Forms.Button();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.txtLnameUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.txtLRefCpt);
            this.panel1.Controls.Add(this.txtLAdresse);
            this.panel1.Controls.Add(this.txtLsolde);
            this.panel1.Controls.Add(this.btnDeconnexion);
            this.panel1.Controls.Add(this.btnCmd);
            this.panel1.Controls.Add(this.btnPanier);
            this.panel1.Controls.Add(this.btnCatalogue);
            this.panel1.Controls.Add(this.txtLnameUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Name = "panel1";
            // 
            // txtLRefCpt
            // 
            resources.ApplyResources(this.txtLRefCpt, "txtLRefCpt");
            this.txtLRefCpt.Name = "txtLRefCpt";
            // 
            // txtLAdresse
            // 
            resources.ApplyResources(this.txtLAdresse, "txtLAdresse");
            this.txtLAdresse.Name = "txtLAdresse";
            // 
            // txtLsolde
            // 
            resources.ApplyResources(this.txtLsolde, "txtLsolde");
            this.txtLsolde.Name = "txtLsolde";
            // 
            // btnDeconnexion
            // 
            resources.ApplyResources(this.btnDeconnexion, "btnDeconnexion");
            this.btnDeconnexion.BackColor = System.Drawing.Color.Azure;
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnCmd
            // 
            resources.ApplyResources(this.btnCmd, "btnCmd");
            this.btnCmd.BackColor = System.Drawing.Color.Azure;
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.UseVisualStyleBackColor = false;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // btnPanier
            // 
            resources.ApplyResources(this.btnPanier, "btnPanier");
            this.btnPanier.BackColor = System.Drawing.Color.Azure;
            this.btnPanier.Name = "btnPanier";
            this.btnPanier.UseVisualStyleBackColor = false;
            this.btnPanier.Click += new System.EventHandler(this.btnPanier_Click);
            // 
            // btnCatalogue
            // 
            resources.ApplyResources(this.btnCatalogue, "btnCatalogue");
            this.btnCatalogue.BackColor = System.Drawing.Color.Azure;
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.UseVisualStyleBackColor = false;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // txtLnameUser
            // 
            resources.ApplyResources(this.txtLnameUser, "txtLnameUser");
            this.txtLnameUser.Name = "txtLnameUser";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenuClient";
            this.Load += new System.EventHandler(this.FrmMenuClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtLnameUser;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Button btnPanier;
        private System.Windows.Forms.Button btnCatalogue;
        private System.Windows.Forms.Label txtLRefCpt;
        private System.Windows.Forms.Label txtLAdresse;
        private System.Windows.Forms.Label txtLsolde;
    }
}