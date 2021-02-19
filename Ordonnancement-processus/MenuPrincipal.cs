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
        private Simulateur Simulateur = new Simulateur();
        private int ProcessusCounter { get; set; }

        public MenuPrincipal()
        {
            InitializeComponent();
            ProcessusCounter = 0;
        }

        private void btn_ajouterProcessus_Click(object sender, EventArgs e)
        {
            MenuCreationProcessus menuCreationProcessus = new MenuCreationProcessus(ProcessusCounter);
            menuCreationProcessus.FormClosing += new FormClosingEventHandler(AddProcessusToDgv);
            menuCreationProcessus.Show();
        }

        private void ClearDataTable()
        {
            ProcessusDataTable = new DataTable();
            ProcessusBindingSource.DataSource = ProcessusDataTable;
            dgv_processus.DataSource = ProcessusBindingSource;
        }

        private void AddProcessusToDgv(object sender, FormClosingEventArgs e)
        {
            ClearDataTable();

            MenuCreationProcessus processusForm = sender as MenuCreationProcessus;
            Simulateur.ProcessusList.Add(processusForm.Processus);
            ProcessusCounter += 1;

            Simulateur.CreateDataTable(ProcessusDataTable);
        }

        private void btn_lancer_Click(object sender, EventArgs e)
        {
            dgv_processus.ClearSelection();
            dgv_processus.RowsDefaultCellStyle.BackColor = Color.White;
            Simulateur.Simulation(dgv_processus);
        }

        private void radioButton_pp_CheckedChanged(object sender, EventArgs e)
        {
            Simulateur.PolitiqueOrdonnancement = "pp";
        }

        private void radioButton_pca_CheckedChanged(object sender, EventArgs e)
        {
            Simulateur.PolitiqueOrdonnancement = "paps";
        }
    }
}
