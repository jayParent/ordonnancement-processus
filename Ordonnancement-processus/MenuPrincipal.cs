using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordonnancement_processus
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_ajouterProcessus_Click(object sender, EventArgs e)
        {
            MenuCreationProcessus menuCreationProcessus = new MenuCreationProcessus();
            menuCreationProcessus.Show();
        }

        private void btn_lancer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
