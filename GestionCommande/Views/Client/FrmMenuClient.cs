using Gestion_Commande.Views.Security;
using GestionCommande;
using GestionCommande.Dto;
using GestionCommande.Views.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Commande.Views.Client
{
    public partial class FrmMenuClient : Form
    {
        private GestionCommande.Client userConnect;
        private static List<ProdPanier> listPanier;

        public static List<ProdPanier> ListPanier { get => listPanier; set => listPanier = value; }

        public FrmMenuClient()
        {
            InitializeComponent();
        }

        public FrmMenuClient(GestionCommande.Client user)
        {
            InitializeComponent();
            userConnect = user;
        }

        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmCatalogue frm = new FrmCatalogue(userConnect);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPanier_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmPanier frm = new FrmPanier(userConnect);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            clearChildren();
            FrmCommande frm = new FrmCommande();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMenuClient_Load(object sender, EventArgs e)
        {
            loadFrmCatalogue();
            txtLnameUser.Text= "Bienvenue, "+ userConnect.nom + " " + userConnect.prenom;
            txtLAdresse.Text = "Adresse : " + userConnect.adresse;
            txtLRefCpt.Text = "REF Compte : " + userConnect.refCpte;
            txtLsolde.Text = "Solde Compte : " + userConnect.soldeCpte + " FCFA";
        }

        private void loadFrmCatalogue()
        {
            clearChildren();
            FrmCatalogue frm = new FrmCatalogue(userConnect);
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (listPanier==null)
            {
                clearChildren();
                FrmConnexion frm = new FrmConnexion();
                frm.Show();
                this.Hide();
            }
            else
            {
                listPanier.Clear();
                clearChildren();
                FrmConnexion frm = new FrmConnexion();
                frm.Show();
                this.Hide();
            }
        }
    }
}
