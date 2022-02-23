using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.Dto
{
    public class DetailsCommandeDto
    {
        private int id;
        private double qteCmd;
        private double total;
        private string libelle;
        private Byte[] image;
        private Double pu;
        private Double qteStock;

        public string Libelle { get => libelle; set => libelle = value; }
        public int Id { get => id; set => id = value; }
        public double QteCmd { get => qteCmd; set => qteCmd = value; }
        public double Total { get => total; set => total = value; }
        public byte[] Image { get => image; set => image = value; }
        public double Pu { get => pu; set => pu = value; }
        public double QteStock { get => qteStock; set => qteStock = value; }
    }
}
