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

namespace Gestion_Commande.Views.Client
{
    public partial class FrmPanier : Form
    {
        private IServices service = Fabrique.getInstanceService();
        private ProdPanier productSelected;
        private GestionCommande.Client userConnected;

        public FrmPanier()
        {
            InitializeComponent();
        }

        public FrmPanier(GestionCommande.Client user)
        {
            InitializeComponent();
            userConnected = user;
        }


        private void loadDataGridView()
        {
            dtgvPanier.AutoGenerateColumns = false;
            dtgvPanier.DataSource =FrmMenuClient.ListPanier ;
        }

        private void dtgvPanier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgvPanier.Rows[e.RowIndex];
            row.Selected = true;
            productSelected = (ProdPanier)row.DataBoundItem;
        }

        int i;
        List<DetailsCmd> detailsCmds;
        private void btn_ValiderCdm_Click(object sender, EventArgs e)
        {
            Commande cmd = new Commande()
            {
                dateCmd = DateTime.Now,
                totalCmd = Convert.ToDouble(tot),
                isPaid = false,
                ClientId=userConnected.IdUser,
                adresseLiv=txtAdresse.Text
            };
            service.addCommande(cmd);
            detailsCmds = new List<DetailsCmd>();
            foreach (ProdPanier d in FrmMenuClient.ListPanier)
            {
                DetailsCmd de = new DetailsCmd()
                {
                    qteCmd = d.QteCmd,
                    ProduitId = d.Id,
                    CommandeId = cmd.IdCmd,
                    total = d.Total
                };
                detailsCmds.Add(de);
            }
            i=service.addDetailsCmd(detailsCmds);
            if ( i== null)
            {
                MessageBox.Show("Commande non validé",
                    "Validation Commande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Commande enrégistrée",
                    "Validation Commande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                FrmMenuClient.ListPanier.Clear();
                dtgvPanier.Update();
            }
        }

        private void FrmPanier_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadTotalPanier();
            txtAdresse.Text = "Adresse Livraison";
        }

        private void btn_DeleteCmd_Click(object sender, EventArgs e)
        {
            FrmMenuClient.ListPanier.Remove(productSelected);
            dtgvPanier.Update();
            loadTotalPanier();
        }

        Double tot = 0;
        public void loadTotalPanier()
        {
            if (FrmMenuClient.ListPanier == null)
            {
                txtLtotal.Text = "0 FCFA";
            }
            else
            {
                foreach (ProdPanier p in FrmMenuClient.ListPanier)
                {
                    tot += p.Total;
                }
                txtLtotal.Text = Convert.ToString(tot)+ " FCFA";
            }
            
        }

        private void cboAdresse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboAdresse.SelectedItem.ToString().Equals("MON ADRESSE"))
            {
                txtAdresse.Text = userConnected.adresse;
                txtAdresse.Enabled = false;
            }
            else if (cboAdresse.SelectedItem.ToString().Equals("AUTRE"))
            {
                txtAdresse.Clear();
                txtAdresse.Enabled = true;
            }
        }


        private void txtAdresse_Enter(object sender, EventArgs e)
        {
            txtAdresse.Text = "";
        }
    }
}
