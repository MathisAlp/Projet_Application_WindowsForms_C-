using Gestion_Commande.Utills;
using Gestion_Commande.Views.Client;
using Gestion_Commande.Views.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommande
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConnexion());

            */Model1Container model = new Model1Container();
            Client cl = new Client()
            {
                login = "client1@gmail.com",
                password = "1234",
                nom = "Warrior",
                prenom = "Thomas",
                role = "ROLE_CLIENT",
                adresse = "Dakar, Point E",
                telephone = 78451296,
                refCpte = "REF001002003",
                soldeCpte = 80000
            };
            model.User.Add(cl);
            model.SaveChanges();

            Client cl1 = new Client()
            {
                login = "client2@gmail.com",
                password = "1234",
                nom = "Golden",
                prenom = "Steph",
                role = "ROLE_CLIENT",
                adresse = "Dakar, Medina",
                telephone = 77415296,
                refCpte = "REF002003004",
                soldeCpte = 120000
            };
            model.User.Add(cl1);
            model.SaveChanges();

            Secretaire u = new Secretaire()
            {
                login = "secretaire@gmail.com",
                password = "1234",
                nom = "Diop",
                prenom = "Ramatoulaye",
                role = "ROLE_SECRETAIRE",
            };
            model.User.Add(u);
            model.SaveChanges();

            RespoStock u1 = new RespoStock()
            {
                login = "respostock@gmail.com",
                password = "1234",
                nom = "Gari",
                prenom = "Cru",
                role = "ROLE_RS",
            };
            model.User.Add(u1);
            model.SaveChanges();

            Comptable u2 = new Comptable()
            {
                login = "comptable@gmail.com",
                password = "1234",
                nom = "Dialo",
                prenom = "Tamaré",
                role = "ROLE_COMPTABLE",
            };
            model.User.Add(u2);
            model.SaveChanges();

            Livreur u3 = new Livreur()
            {
                login = "livreur1@gmail.com",
                password = "1234",
                nom = "Bande",
                prenom = "Sadio",
                role = "ROLE_LIVREUR",
            };
            model.User.Add(u3);
            model.SaveChanges();

            Livreur u4 = new Livreur()
            {
                login = "livreur2@gmail.com",
                password = "1234",
                nom = "Claudel",
                prenom = "Jerry",
                role = "ROLE_LIVREUR",
            };
            model.User.Add(u4);
            model.SaveChanges();

            Produit prod = new Produit()
            {
                libelle = "Sandale Adidas",
                qteStock = 30,
                prixUnitaire = 3000,
                description = "Sandale de sortie Adidas pointure 40",
                img = MyImage.convertImageToByte("C:/Users/MATHIS/Desktop/Projet C# L3/GestionCommande/Ressources/sandale adidas.jpg")
            };
            model.Produit.Add(prod);
            model.SaveChanges();

            Produit prod1 = new Produit()
            {
                libelle = "Yeezy 500",
                qteStock = 40,
                prixUnitaire = 20000,
                description = "Collaboration entre Adidas et Kanye Wesk pointure 43",
                img = MyImage.convertImageToByte("C:/Users/MATHIS/Desktop/Projet C# L3/GestionCommande/Ressources/yeezy 500.jpg")
            };
            model.Produit.Add(prod1);
            model.SaveChanges();

            Produit prod2 = new Produit()
            {
                libelle = "Air Force 1",
                qteStock = 50,
                prixUnitaire = 10000,
                description = "Paire de sneaker Nike pointure 40",
                img = MyImage.convertImageToByte("C:/Users/MATHIS/Desktop/Projet C# L3/GestionCommande/Ressources/Af1.jpg")
            };
            model.Produit.Add(prod2);
            model.SaveChanges();

            Produit prod3 = new Produit()
            {
                libelle = "Converse CDG",
                qteStock = 20,
                prixUnitaire = 15000,
                description = "Collaboration entre Converse et la firme Comme Des Garcons pointure 45",
                img = MyImage.convertImageToByte("C:/Users/MATHIS/Desktop/Projet C# L3/GestionCommande/Ressources/converse cdg.jpg")
            };
            model.Produit.Add(prod3);
            model.SaveChanges();

            Produit prod4 = new Produit()
            {
                libelle = "Air Jordan 1 Low",
                qteStock = 30,
                prixUnitaire = 15000,
                description = "Collaboration entre Nike et le joueur de Basket Jordan pointure 44",
                img = MyImage.convertImageToByte("C:/Users/MATHIS/Desktop/Projet C# L3/GestionCommande/Ressources/Aj1 low.png")
            };
            model.Produit.Add(prod4);
            model.SaveChanges();

            Produit prod5 = new Produit()
            {
                libelle = "Dr's Martens",
                qteStock = 20,
                prixUnitaire = 15000,
                description = "Paire de soulier Docteur Martens 1945 pointure 42",
                img = MyImage.convertImageToByte("C:/Users/MATHIS/Desktop/Projet C# L3/GestionCommande/Ressources/doc martens.jpg")
            };
            model.Produit.Add(prod5);
            model.SaveChanges();//*/
        }
    }
}
