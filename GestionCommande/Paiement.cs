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
    
    public partial class Paiement
    {
        public int IdPaiement { get; set; }
        public System.DateTime datePaid { get; set; }
        public double montant { get; set; }
        public int ClientId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Commande Commande { get; set; }
    }
}