using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

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
                    int indexProcBloque = 0;




                    //for (int i = 0; i < processusOrdonneParPriorite.Count; i++)
                    //{
                    //    List<Instruction> instructions = processusOrdonneParPriorite[i].Instructions;
                    //    for (int j = 0; j < instructions.Count; j++)
                    //    {
                    //        if (instructions[j].Type == "calcul")
                    //        {
                    //            ordonnancement.Add(instructions[j]);
                    //        }
                    //        else if (instructions[j].Type == "es")
                    //        {
                    //            indexProcBloque = j;
                    //            i++;
                    //        }
                    //    }
                    //}
                    //foreach (Processus processus in processusOrdonneParPriorite)
                    //{
                    //    foreach (Instruction instruction in processus.Instructions)
                    //    {
                    //        ordonnancement.Add(instruction);
                    //    }
                    //}

                    break;
            }

            return ordonnancement;
        }

        // États des processus
        // En attente => Élu => Endormi (quand un processus fait E/S, ordonnanceur passe à un autre processus) => En attente => Terminé

        // Gestion de la famine
        // Augmenter la priorité des processus qui n'ont pas été élu depuis longtemps

        public void Simulation()
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
