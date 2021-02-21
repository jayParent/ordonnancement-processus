using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ordonnancement_processus.Classes
{
    public class Simulateur
    {
        public string PolitiqueOrdonnancement { get; set; }
        public List<Processus> ProcessusList { get; set; }
        public List<Instruction> Ordonnancement = new List<Instruction>();
        public int OrdonnancementIndex { get; set; }
        public System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();

        public Simulateur()
        {
            PolitiqueOrdonnancement = "pp";
            OrdonnancementIndex = 0;
            ProcessusList = new List<Processus>();
        }

        public void CreateDataTable(DataTable dataTable)
        {
            foreach (Processus processus in ProcessusList)
            {
                DataColumn processusHeader = new DataColumn(processus.ProcessusInfo);

                dataTable.Columns.Add(processusHeader);
            }

            for (int i = 0; i < 12; i++)
            {
                DataRow row = dataTable.NewRow();

                foreach (Processus processus in ProcessusList)
                {
                    if(i <= processus.Instructions.Count - 1)
                    {
                        row[processus.ProcessusInfo] = processus.Instructions[i].Type;
                    }
                    else
                    {
                        row[processus.ProcessusInfo] = "";
                    }
                }

                dataTable.Rows.Add(row);
            }
        }

        public List<Instruction> OrdonnancementDesProcessus()
        {
            List<Instruction> ordonnancement = new List<Instruction>();

            switch (PolitiqueOrdonnancement)
            {
                case "pp":
                    OrdonnancementParPriorite(ordonnancement);
                    break;
                case "paps":
                    OrdonnancementPAPS(ordonnancement);
                    break;
            }

            return ordonnancement;
        }

        private void OrdonnancementParPriorite(List<Instruction> ordonnancement)
        {
            List<Processus> processusOrdonneParPriorite = ProcessusList.OrderByDescending(p => p.Priorite).ToList();
            bool running = true;

            while (running)
            {
                for (int i = 0; i < processusOrdonneParPriorite.Count; i++)
                {
                    for (int j = processusOrdonneParPriorite[i].InstructionCourante; j < processusOrdonneParPriorite[i].Instructions.Count; j++)
                    {
                        ordonnancement.Add(processusOrdonneParPriorite[i].Instructions[j]);

                        processusOrdonneParPriorite[i].InstructionCourante += 1;

                        if (processusOrdonneParPriorite[i].InstructionCourante == processusOrdonneParPriorite[i].InstructionsTotal)
                        {
                            processusOrdonneParPriorite[i].Termine = true;
                        }

                        if (processusOrdonneParPriorite[i].Instructions[j].Type == "es")
                        {
                            break;
                        }
                    }
                }

                foreach (Processus processus in processusOrdonneParPriorite)
                {
                    if (processus.Termine == false)
                        break;
                    else
                        running = false;
                }
            }
        }

        private void OrdonnancementPAPS(List<Instruction> ordonnancement)
        {
            bool running = true;

            while (running)
            {
                for (int i = 0; i < ProcessusList.Count; i++)
                {
                    for (int j = ProcessusList[i].InstructionCourante; j < ProcessusList[i].Instructions.Count; j++)
                    {
                        ordonnancement.Add(ProcessusList[i].Instructions[j]);

                        ProcessusList[i].InstructionCourante += 1;

                        if (ProcessusList[i].InstructionCourante == ProcessusList[i].InstructionsTotal)
                        {
                            ProcessusList[i].Termine = true;
                        }

                        if (ProcessusList[i].Instructions[j].Type == "es")
                        {
                            break;
                        }
                    }
                }

                foreach (Processus processus in ProcessusList)
                {
                    if (processus.Termine == false)
                        break;
                    else
                        running = false;
                }
            }
        }

        private void NextInstruction(Object sender, EventArgs e, DataGridView dgv, DataTable dataTable)
        {
            if (Ordonnancement[OrdonnancementIndex].Temps == 1)
                Timer.Interval = 1000;
            else if (Ordonnancement[OrdonnancementIndex].Temps == 3)
                Timer.Interval = 3000;

            Processus processus = ProcessusList.Find(p => p.Pid == Ordonnancement[OrdonnancementIndex].ProcessusId);
            List<Processus> processusBloques = ProcessusList.Where(p => p.Pid != Ordonnancement[OrdonnancementIndex].ProcessusId).ToList();

            if(processus.Etat == "En attente")
            {
                UpdateProcessusEtat(dataTable, processus, "Elu");
            }

            foreach (Processus p in processusBloques)
            {
                if(p.Etat == "Elu")
                    UpdateProcessusEtat(dataTable, p, "Bloque");
            }

            if(Ordonnancement[OrdonnancementIndex].Row == processus.InstructionsTotal - 1)
            {
                UpdateProcessusEtat(dataTable, processus, "Termine");
            }

            dgv.Rows[Ordonnancement[OrdonnancementIndex].Row].Cells[Ordonnancement[OrdonnancementIndex].Col].Style.BackColor = Color.LightGreen;
            OrdonnancementIndex += 1;

            if (OrdonnancementIndex >= Ordonnancement.Count)
            {
                Timer.Stop();
                return;
            }
        }

        private void UpdateProcessusEtat(DataTable dataTable, Processus processus, string etat)
        {
            string oldColName = processus.ProcessusInfo;
            processus.Etat = etat;

            if (etat == "Elu")
                processus.Priorite -= 1;

            processus.ProcessusInfo = string.Format("{0}\nPID: {1}\nPriorité: {2}\nÉtat: {3}", processus.Nom, processus.Pid, processus.Priorite, processus.Etat);

            dataTable.Columns[oldColName].ColumnName = processus.ProcessusInfo;
        }

        public void Simulation(DataGridView dgv, DataTable dataTable)
        {
            Ordonnancement = OrdonnancementDesProcessus();
            OrdonnancementIndex = 0;

            Timer.Tick += new EventHandler((sender, e) => NextInstruction(sender, e, dgv, dataTable));
            Timer.Interval = 1000;
            Timer.Enabled = true;
            Timer.Start();
        }
    }
}
