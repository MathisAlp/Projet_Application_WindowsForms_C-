using Gestion_Commande.Views.Security;
using GestionCommande.Dto;
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

namespace GestionCommande.Views.Secretaire
{
    public partial class FrmMenuSecretaire : Form
    {
        private User userConnected;
        private Commande cmdSelected;
        private IServices service = Fabrique.Fabrique.getInstanceService();

        public FrmMenuSecretaire()
        {
            InitializeComponent();
        }

        public FrmMenuSecretaire(User user)
        {
            InitializeComponent();
            userConnected = user;
        }

        private void FrmMenuSecretaire_Load(object sender, EventArgs e)
        {
            txtLname.Text = "Bienvenue, "+userConnected.nom + " " + userConnected.prenom;
            txtLrole.Text = "Role: "+userConnected.role;
            gpbDetails.Visible = false;
            loadDtgvCommande();
        }

        private void loadDtgvCommande()
        {
            dtgvCmd.AutoGenerateColumns = false;
            dtgvCmd.DataSource = service.showAllCommande();
        }

        private void loadDtgvDetailsCmd()
        {
            int idCmd = cmdSelected.IdCmd;
            dtgvDetailsCmd.AutoGenerateColumns = false;
            dtgvDetailsCmd.DataSource = service.searchDetailsCmdByCmd(idCmd);
        }

        int iValid;
        private void btnAttente_Click(object sender, EventArgs e)
        {
            int intComd = cmdSelected.IdCmd;
            MessageBox.Show(Convert.ToString(intComd));
            Commande cmd = service.searchCommandeById(intComd);
            iValid =service.updateCommande(cmd, "En Attente");
            if (iValid == null)
            {
                MessageBox.Show("Modification non effectuée !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Commande mise en attente",
                    "Commande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                gpbDetails.Visible = false;
                loadDtgvCommande();
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int intComd = cmdSelected.IdCmd;
            MessageBox.Show(Convert.ToString(intComd));
            Commande cmd = service.searchCommandeById(intComd);
            iValid =service.updateCommande(cmd, "En cours");
            if (iValid == null)
            {
                MessageBox.Show("Modification non effectuée !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Commande envoyée au Responsable des Stocks",
                    "Commande",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                gpbDetails.Visible = false;
                loadDtgvCommande();
            }

        }

        private void dtgvCmd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CommandeDto cmdDto = new CommandeDto();
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvCmd.Rows.Count)
            {
                DataGridViewRow row = dtgvCmd.Rows[e.RowIndex];
                row.Selected = true;
                cmdSelected = cmdDto.toCommande((CommandeDto)row.DataBoundItem);
                gpbDetails.Visible = true;
                txtAdresse.Text = "Adresse Livraison: " + cmdSelected.adresseLiv;
                txtTotal.Text = "Total Commande: " + cmdSelected.totalCmd.ToString() + " FCFA";
                loadDtgvDetailsCmd();
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            FrmConnexion frm = new FrmConnexion();
            frm.Show();
            this.Hide();
        }
    }
}
