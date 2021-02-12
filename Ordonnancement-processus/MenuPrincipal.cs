using Ordonnancement_processus.Classes;
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
        private DataTable ProcessusDataTable = new DataTable();
        private BindingSource ProcessusBindingSource = new BindingSource();

        public MenuPrincipal()
        {
            InitializeComponent();
            dgv_processus.AutoGenerateColumns = true;
            ProcessusBindingSource.DataSource = ProcessusDataTable;
            dgv_processus.DataSource = ProcessusBindingSource;
            dgv_processus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void btn_ajouterProcessus_Click(object sender, EventArgs e)
        {
            MenuCreationProcessus menuCreationProcessus = new MenuCreationProcessus();
            menuCreationProcessus.FormClosing += new FormClosingEventHandler(AddProcessusToDgv);
            menuCreationProcessus.Show();
        }

        private void AddProcessusToDgv(object sender, FormClosingEventArgs e)
        {
            MenuCreationProcessus processusForm = sender as MenuCreationProcessus;

            string nomProcessus = processusForm.Processus.Nom;

            ProcessusDataTable.Columns.Add(nomProcessus);

            DataRow processusInfo = ProcessusDataTable.NewRow();
            processusInfo[nomProcessus] = processusForm.Processus.Pid;

            ProcessusDataTable.Rows.Add(processusInfo);

        }

        private void btn_lancer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
