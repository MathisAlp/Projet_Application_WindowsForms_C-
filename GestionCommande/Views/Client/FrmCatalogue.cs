
using Gestion_Commande.Utills;
using Gestion_Commande.Views.Client;
using GestionCommande;
using GestionCommande.Dto;
using GestionCommande.Fabrique;
using GestionCommande.Service;
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

namespace GestionCommande.Views.Client
{
    public partial class FrmCatalogue : Form
    {
        private IServices service = Fabrique.Fabrique.getInstanceService();
        private Produit productSelected;
        private GestionCommande.Client userConnected;
        public FrmCatalogue()
        {
            InitializeComponent();
        }

        public FrmCatalogue(GestionCommande.Client user)
        {
            InitializeComponent();
            userConnected = user;
        }

        private void FrmCatalogue_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            FrmMenuClient.ListPanier = new List<ProdPanier>();
        }

        private void loadDataGridView()
        {
            dgvProduit.AutoGenerateColumns = false;
            dgvProduit.DataSource = service.showAllProduit();
        }

        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        Produit prod;
        int idProd;
        private void dgvProduit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgvProduit.Rows.Count)
            {
                DataGridViewRow row = dgvProduit.Rows[e.RowIndex];
                row.Selected = true;
                productSelected = (Produit)row.DataBoundItem;
                /*idProd = int.Parse(row.Cells[3].Value.ToString());
                prod = service.searchProduitById(idProd);*/
                paneDetails.Visible=true;
                txtLDescription.Text = "Description: "+"\n"+ productSelected.description;
                txtPrix.Text = "Prix: "+"\n"+ productSelected.prixUnitaire.ToString()+" FCFA";
                pctProduit.Image = MyImage.convertByteToImage(productSelected.img);
            }
        }

        private void txtQteSaisie_KeyUp(object sender, KeyEventArgs e)
        {
            try {

                double totalProduit;

                if (txtQteSaisie.Text.Trim() == null)
                {
                    totalProduit = 0;
                    //txtTotalForPanier.Text = "Bonjour";
                }
                else
                {
                    txtTotalForPanier.Text = (Convert.ToDouble(txtQteSaisie.Text) * productSelected.prixUnitaire).ToString();
                    txtTotalForPanier.Enabled = false;
                }

            } catch {
                txtTotalForPanier.Clear();
             }
            
        }


        
        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            txtQteSaisie.Clear();
            txtTotalForPanier.Clear();
            paneDetails.Visible = false;
        }

        
        private void btnAddPanier_Click(object sender, EventArgs e)
        {
            String qte = txtQteSaisie.Text;
            if (string.IsNullOrEmpty(qte))
            {
                MessageBox.Show("Produit non ajouté - Vérifiez si tous les champs sont saisis",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                ProdPanier p = new ProdPanier();
                p.Id = productSelected.IdProduit;
                p.QteCmd= Convert.ToDouble(txtQteSaisie.Text);
                p.Libelle = productSelected.libelle;
                p.Total = Convert.ToDouble(txtTotalForPanier.Text);
                p.Cl= (GestionCommande.Client)service.searchUserById(userConnected.IdUser);
                p.Image = productSelected.img;
                p.Pu = productSelected.prixUnitaire;
                FrmMenuClient.ListPanier.Add(p);
                MessageBox.Show("Produit bien ajouté au panier",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtQteSaisie.Clear();
                txtTotalForPanier.Clear();
                paneDetails.Visible = false;
            }
        }

    }
}
