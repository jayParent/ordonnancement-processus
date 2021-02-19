using Ordonnancement_processus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ordonnancement_processus
{
    public partial class MenuCreationProcessus : Form
    {
        public Processus Processus { get; set; }
        private int ProcessusCounter { get; set; }

        public MenuCreationProcessus(int processusCounter)
        {
            InitializeComponent();
            ProcessusCounter = processusCounter;
        }

        private void button_creerProcessus_Click(object sender, EventArgs e)
        {
            string nom = textBox_nom.Text;
            int priorite = (int)numericUpDown_priorite.Value;
            int instructionsCalcul = (int)numericUpDown_calculs.Value;
            int instructionsEs = (int)numericUpDown_es.Value;
            int threads = 1;

            if (radioButton_twoThreads.Checked)
                threads = 2;
            else if (radioButton_threeThreads.Checked)
                threads = 3;

            if(instructionsCalcul + instructionsEs > 12)
                ShowErrorMessageBox();
            else
            {
                Processus = new Processus(ProcessusCounter, nom, priorite, instructionsCalcul, instructionsEs, threads);
                Close();
            }
            
        }

        private void ShowErrorMessageBox()
        {
            string message = "Veuillez entrer un nombre d'instructions maximal de 12.";
            string caption = "Erreur";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }

        private void button_annulerProcessus_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
