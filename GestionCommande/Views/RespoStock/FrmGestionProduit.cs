using Gestion_Commande.Utills;
using GestionCommande.Service;
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
    public partial class FrmGestionProduit : Form
    {
        private Produit productSelected;
        private IServices service = Fabrique.Fabrique.getInstanceService();
        public FrmGestionProduit()
        {
            InitializeComponent();
        }

        int i;

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pctBproduit.ImageLocation);
           Produit prod = new Produit()
            {
                libelle = txtBlibelle.Text,
                qteStock = Convert.ToDouble(txtBqteStock.Text),
                prixUnitaire = Convert.ToDouble(txtBprixU.Text),
                description = txtBdescrption.Text
            };
            if (pctBproduit.ImageLocation==null)
            {
                prod.img = MyImage.convertImageToByte("C:\\Users\\MATHIS\\Desktop\\Projet C# L3\\GestionCommande\\Ressources\\avatar-produit.jpg");
            }
            else
            {
                prod.img = MyImage.convertImageToByte(pctBproduit.ImageLocation);
            }
            i= service.addProduit(prod);
            if (i == null)
            {
                MessageBox.Show("Produit Non Enregistré !! - Vérifiez si tous les champs sont saisis",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Produit Enregistré !!",
                    "Enrégistrement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                clearChamp();
                loadDgtvProduit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            productSelected.prixUnitaire = Convert.ToDouble(txtBprixU.Text);
            productSelected.libelle = txtBlibelle.Text;
            productSelected.description = txtBdescrption.Text;
            productSelected.qteStock = Convert.ToDouble(txtBqteStock.Text);
            if (pctBproduit.ImageLocation == null)
            {
                productSelected.img = productSelected.img;
            }
            else
            {
                productSelected.img = MyImage.convertImageToByte(pctBproduit.ImageLocation);
            }
            i =service.updateProduit(productSelected);
            if (i == null)
            {
                MessageBox.Show("Modification non effectuée !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Modification effectuée",
                    "Modifcation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                clearChamp();
                loadDgtvProduit();
            }
        }

        private void loadDgtvProduit()
        {
            dtgvProduit.AutoGenerateColumns = false;
            dtgvProduit.DataSource = service.showAllProduit();
        }

        private void FrmGestionProduit_Load(object sender, EventArgs e)
        {
            loadDgtvProduit();
            pctBproduit.Image = Image.FromFile("C:\\Users\\MATHIS\\Desktop\\Projet C# L3\\GestionCommande\\Ressources\\avatar-produit.jpg");
        }

        private void dtgvProduit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvProduit.Rows.Count)
            {
                DataGridViewRow row = dtgvProduit.Rows[e.RowIndex];
                row.Selected = true;
                productSelected = (Produit)row.DataBoundItem;
                txtBlibelle.Text = productSelected.libelle;
                txtBprixU.Text = productSelected.prixUnitaire.ToString();
                txtBqteStock.Text = productSelected.qteStock.ToString();
                txtBdescrption.Text = productSelected.description;
                pctBproduit.Image = MyImage.convertByteToImage(productSelected.img);
            }
        }

        public void clearChamp()
        {
            txtBdescrption.Clear();
            txtBprixU.Clear();
            txtBqteStock.Clear();
            txtBlibelle.Clear();
            pctBproduit.Image=Image.FromFile("C:\\Users\\MATHIS\\Desktop\\Projet C# L3\\GestionCommande\\Ressources\\avatar-produit.jpg");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pctBproduit.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur survenue à l'ajout de l'image",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamp();
        }
    }
}
