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

namespace GestionCommande.Views.RespoStock
{
    public partial class FrmLivraison : Form
    {
        private IServices service = Fabrique.Fabrique.getInstanceService();
        private static List<CommandeDto> cmdDtos;
        private static List<Commande> cmds;
        private CommandeDto cmdDtoSelected;
        public FrmLivraison()
        {
            InitializeComponent();
        }


        private void dtgvCmd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dtgvCmd.Rows.Count)
            {
                DataGridViewRow row = dtgvCmd.Rows[e.RowIndex];
                row.Selected = true;
                cmdDtoSelected = (CommandeDto)row.DataBoundItem;
            }
        }

        private void loadDtgvCmd()
        {
            dtgvCmd.AutoGenerateColumns = false;
            dtgvCmd.DataSource = service.showAllCmdEncours();
        }

        private void loadDtgvDetailsLivraison()
        {
            dtgvCmdLivraison.AutoGenerateColumns = false;
            dtgvCmdLivraison.DataSource = cmdDtos;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            cmdDtos.Add(cmdDtoSelected);
            loadDtgvDetailsLivraison();
            gpbDetailsLivraison.Visible = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Livraison liv = new Livraison()
            {
                dateLiv = DateTime.Now/*,
                int idLiv = cboLivreur.v
                Livreur = (GestionCommande.Livreur)cboLivreur.SelectedItem*/
            };
            foreach(CommandeDto c in cmdDtos)
            {
                cmds = new List<Commande>();
                Commande cmd = new Commande()
                {
                    IdCmd=c.Id,
                    dateCmd=c.DateCmd,
                    totalCmd=c.TotalCmd,
                    isPaid=c.IsPaid,
                    adresseLiv=c.AdresseLiv,
                    statut=c.Statut,
                    Client=c.Cl
                };
                cmds.Add(cmd);
            }
            liv.Commande=cmds;
            int i=service.addLivraison(liv);
            if (i == null)
            {
                MessageBox.Show("Livraison non enrégistrée !!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Livraison enrégistrée",
                    "Livreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                gpbDetailsLivraison.Visible = false;
                cmdDtos.Clear();
                loadDtgvCmd();
            }
            
        }

        private void FrmLivraison_Load(object sender, EventArgs e)
        {
            gpbDetailsLivraison.Visible = false;
            loadComboLIvreur();
            loadDtgvCmd();
            cmdDtos = new List<CommandeDto>();
        }

        private void loadComboLIvreur()
        {
            List<User> liv = service.showAllLivreurs();
            foreach(User u in liv)
            {
                cboLivreur.Items.Add(u.nom+" "+u.prenom);
                cboLivreur.ValueMember = u.IdUser.ToString();
            }
        }
    }
}
