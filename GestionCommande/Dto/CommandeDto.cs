using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.Dto
{
    public class CommandeDto
    {
        private int id;
        private DateTime dateCmd;
        private Double totalCmd;
        private Boolean isPaid;
        private string adresseLiv;
        private string statut;
        private string nomClient;
        private Client cl; 
        public CommandeDto()
        {

        }

        public int Id { get => id; set => id = value; }
        public DateTime DateCmd { get => dateCmd; set => dateCmd = value; }
        public double TotalCmd { get => totalCmd; set => totalCmd = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        public string AdresseLiv { get => adresseLiv; set => adresseLiv = value; }
        public string Statut { get => statut; set => statut = value; }
        public string NomClient { get => nomClient; set => nomClient = value; }
        public Client Cl { get => cl; set => cl = value; }

        public Commande toCommande(CommandeDto cmdDto)
        {
            Commande cmd = new Commande()
            {
                IdCmd=cmdDto.Id,
                dateCmd=cmdDto.DateCmd,
                totalCmd=cmdDto.TotalCmd,
                isPaid=cmdDto.IsPaid,
                adresseLiv=cmdDto.AdresseLiv,
                statut=cmdDto.statut,
                Client=cmdDto.cl
            };
            return cmd;
        }
    }
}
