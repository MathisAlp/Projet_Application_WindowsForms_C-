using GestionCommande.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommande.Fabrique
{
    public class Fabrique
    {
        public static IServices getInstanceService()
        {
            return new Services() { };

        }
    }
}
