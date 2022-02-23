using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Commande.Views.Client;
using GestionCommande.Service;
using GestionCommande.Fabrique;
using GestionCommande;
using GestionCommande.Views.RespoStock;
using GestionCommande.Views.Secretaire;
using GestionCommande.Views.Comptable;
using GestionCommande.Views.Livreur;

namespace Gestion_Commande.Views.Security
{
    public partial class FrmConnexion : Form
    {
        private IServices service = Fabrique.getInstanceService();

        public FrmConnexion()
        {
            InitializeComponent();
        }


        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login ou Mot de Passe Obligatoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                User user = service.searchUserByloginAndPassword(login, password);
                if (user == null)
                {
                    txtError.Visible = true;
                    txtLogin.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    if (user.role=="ROLE_CLIENT")
                    {
                        FrmMenuClient frm = new FrmMenuClient((GestionCommande.Client)user);
                        frm.Show();
                        this.Hide();
                    }else if (user.role == "ROLE_RS")
                    {
                        FrmMenuRs frm = new FrmMenuRs(user);
                        frm.Show();
                        this.Hide();
                    }else if (user.role=="ROLE_SECRETAIRE")
                    {
                        FrmMenuSecretaire frm = new FrmMenuSecretaire(user);
                        frm.Show();
                        this.Hide();
                    }
                    else if (user.role == "ROLE_COMPTABLE")
                    {
                        FrmMenuComptable frm = new FrmMenuComptable(user);
                        frm.Show();
                        this.Hide();
                    }else if (user.role=="ROLE_LIVREUR")
                    {
                        FrmMenuLivreur frm = new FrmMenuLivreur(user);
                        frm.Show();
                        this.Hide();
                    }


                }
            }
        }

        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            FrmInscription frm = new FrmInscription();
            frm.Show();
            this.Hide();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            txtError.Hide();
        }
    }
}
