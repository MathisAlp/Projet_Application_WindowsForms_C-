using Gestion_Commande.Views.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommande.Views.RespoStock
{
    public partial class FrmMenuRs : Form
    {
        private User userConnect;
        public FrmMenuRs()
        {
            InitializeComponent();
        }
        public FrmMenuRs(User user)
        {
            InitializeComponent();
            userConnect = user;
        }

        private void btnFormLivraison_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmLivraison frm = new FrmLivraison();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmConnexion frm = new FrmConnexion();
            frm.Show();
            this.Hide();
        }

        private void btnFormProduit_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmGestionProduit frm = new FrmGestionProduit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMenuRs_Load(object sender, EventArgs e)
        {
            loadFrmGestionProduit();
            txtLname.Text = "Bienvenue, " + userConnect.nom + " " + userConnect.prenom;
            txtLRole.Text = "Role: " + userConnect.role;
        }

        private void loadFrmGestionProduit()
        {
            clearChildren();
            FrmGestionProduit frm = new FrmGestionProduit();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
