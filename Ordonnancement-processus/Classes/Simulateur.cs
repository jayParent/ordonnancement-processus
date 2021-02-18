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

        public Simulateur()
        {
            PolitiqueOrdonnancement = "pp";
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

                    break;
            }

            return ordonnancement;
        }

        // États des processus
        // En attente => Élu => Endormi (quand un processus fait E/S, ordonnanceur passe à un autre processus) => En attente => Terminé

        // Gestion de la famine
        // Augmenter la priorité des processus qui n'ont pas été élu depuis longtemps


        public void Simulation(DataGridView dgv)
        {
            List<Instruction> ordonnancement = OrdonnancementDesProcessus();

            foreach (Instruction instruction in ordonnancement)
            {
                Console.WriteLine(instruction.Type);

                //if (instruction.Temps == 1)
                //    Thread.Sleep(1000);
                //else if (instruction.Temps == 3)
                //    Thread.Sleep(3000);
            }

            
        }
    }
}
