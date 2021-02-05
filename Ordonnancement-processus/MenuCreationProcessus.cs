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
        public MenuCreationProcessus()
        {
            InitializeComponent();
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

            Processus processus = new Processus(nom, priorite, instructionsCalcul, instructionsEs, threads);
            Close();
        }

        private void button_annulerProcessus_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
