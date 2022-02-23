using GestionCommande.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.Service
{
    public interface IServices
    {
        User searchUserByloginAndPassword(string login, string password);
        List<Produit> showAllProduit();
        int addProduit(Produit prod);
        int addClient(Client client);
        Produit searchProduitById(int id);
        int deleteProduit(Produit prod);
        int updateProduit(Produit prod);
        int updateCommande(Commande cmd, string up);
        int addDetailsCmd(List<DetailsCmd> details);
        int addCommande(Commande cmd);
        List<CommandeDto> showAllCommande();
        List<CommandeDto> showAllCmdEncours();
        Commande searchCommandeById(int id);
        List<Commande> searchCommandesByClient(int id);
        User searchUserById(int id);
        List<DetailsCommandeDto> searchDetailsCmdByCmd(int idCmd);
        int addLivraison(Livraison liv);
        List<User> showAllLivreurs();
        User findLivreurById(int id);
    }
}
