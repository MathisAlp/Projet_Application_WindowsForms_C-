using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.Dto
{
    public class ProdPanier
    {
        private int id;
        private double qteCmd;
        private double total;
        private string libelle;
        private double pu;
        private Client cl;
        private Byte[] image;

        public int Id { get => id; set => id = value; }
        public double QteCmd { get => qteCmd; set => qteCmd = value; }
        public double Total { get => total; set => total = value; }
        public byte[] Image { get => image; set => image = value; }
        public Client Cl { get => cl; set => cl = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public double Pu { get => pu; set => pu = value; }
    }
}
