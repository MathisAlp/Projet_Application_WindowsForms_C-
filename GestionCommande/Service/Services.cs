using GestionCommande.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Commande.Utills;
using System.Data.Entity.Core;
using System.Windows.Forms;

namespace GestionCommande.Service
{
    public class Services : IServices
    {
        private Model1Container model = new Model1Container();

        public Services() { }

        public int addClient(Client client)
        {
            model.User.Add(client);
            return model.SaveChanges();
        }

        public int addCommande(Commande cmd)
        {
            model.Commande.Add(cmd);
            return model.SaveChanges();
        }

        public int addDetailsCmd(List<DetailsCmd> details)
        {
            model.DetailsCmd.AddRange(details);
            return model.SaveChanges();
        }

        public int addLivraison(Livraison liv)
        {
            model.Livraison.Add(liv);
            return model.SaveChanges();
        }

        public int addProduit(Produit prod)
        {
            model.Produit.Add(prod);
            return model.SaveChanges();
        }

        public int deleteProduit(Produit prod)
        {
            model.Produit.Remove(prod);
            return model.SaveChanges();
        }

        public User findLivreurById(int id)
        {
            throw new NotImplementedException();
        }

        public Commande searchCommandeById(int id)
        {
            return model.Commande.Where(c => c.IdCmd== id).FirstOrDefault();
        }

        public List<Commande> searchCommandesByClient(int id)
        {
            return model.Commande.Where(c => c.Client.IdUser == id).ToList();
        }

        public List<DetailsCommandeDto> searchDetailsCmdByCmd(int idCmd)
        {
            List<DetailsCommandeDto> dtos = new List<DetailsCommandeDto>();
            List<DetailsCmd> dtcmds = model.DetailsCmd.Where(dt => dt.CommandeId == idCmd).ToList();
            foreach (DetailsCmd d in dtcmds)
            {
                DetailsCommandeDto dto = new DetailsCommandeDto()
                {
                    Id = d.IdDetailsCmd,
                    QteCmd=d.qteCmd,
                    Total=d.total,
                    Libelle=d.Produit.libelle,
                    Image=d.Produit.img,
                    Pu=d.Produit.prixUnitaire,
                    QteStock=d.Produit.qteStock
                };
                dtos.Add(dto);
            }
            return dtos;
        }

        public Produit searchProduitById(int id)
        {
            return model.Produit.Where(p => p.IdProduit == id).FirstOrDefault();
        }

        public User searchUserById(int id)
        {
            return model.User.Where(u => u.IdUser == id).FirstOrDefault();
        }

        public User searchUserByloginAndPassword(string login, string password)
        {
            return model.User.Where(u => u.login == login & u.password == password).FirstOrDefault();
        }

        public List<CommandeDto> showAllCmdEncours()
        {
            List<CommandeDto> commandeDtos = new List<CommandeDto>();
            List<Commande> commandes = model.Commande.Where(c => c.statut == "En cours").ToList();
            foreach (Commande d in commandes)
            {
                CommandeDto cmd = new CommandeDto()
                {
                    Id = d.IdCmd,
                    DateCmd = d.dateCmd,
                    TotalCmd = d.totalCmd,
                    IsPaid = d.isPaid,
                    AdresseLiv = d.adresseLiv,
                    Statut = d.statut,
                    NomClient = d.Client.nom + " " + d.Client.prenom,
                    Cl = d.Client
                };
                commandeDtos.Add(cmd);
            }
            return commandeDtos;
        }

        public List<CommandeDto> showAllCommande()
        {
            List<CommandeDto> commandeDtos = new List<CommandeDto>();
            List<Commande> commandes = model.Commande.ToList();
            foreach (Commande d in commandes)
            {
                CommandeDto cmd = new CommandeDto()
                {
                    Id = d.IdCmd,
                    DateCmd=d.dateCmd,
                    TotalCmd=d.totalCmd,
                    IsPaid=d.isPaid,
                    AdresseLiv=d.adresseLiv,
                    Statut=d.statut,
                    NomClient=d.Client.nom+" "+d.Client.prenom,
                    Cl=d.Client
                };
                commandeDtos.Add(cmd);
            }
            return commandeDtos;
        }

        public List<User> showAllLivreurs()
        {
            return model.User.Where(u => u.role == "ROLE_LIVREUR").ToList();
        }

        public List<Produit> showAllProduit()
        {
            return model.Produit.ToList();
        }

        public int updateCommande(Commande cmd, string up)
        {
            cmd.statut = up;
            return model.SaveChanges();
        }

        public int updateProduit(Produit prod)
        {
            return model.SaveChanges();
        }
    }
}
