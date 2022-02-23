using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCommande.Views.Comptable
{
    public partial class FrmMenuComptable : Form
    {
        private User userConnected;
        public FrmMenuComptable()
        {
            InitializeComponent();
        }

        public FrmMenuComptable(User user)
        {
            InitializeComponent();
            userConnected = user;
        }
    }
}
