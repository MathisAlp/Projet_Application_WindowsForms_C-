//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCommande
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailsCmd
    {
        public int IdDetailsCmd { get; set; }
        public double qteCmd { get; set; }
        public double total { get; set; }
        public int CommandeId { get; set; }
        public int ProduitId { get; set; }
    
        public virtual Commande Commande { get; set; }
        public virtual Produit Produit { get; set; }
    }
}