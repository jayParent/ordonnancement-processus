using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Ordonnancement_processus.Classes
{
    public class Processus
    {
        public int Pid { get; set; }
        public string Nom { get; set; }
        public int Priorite { get; set; }
        public string Etat { get; set; }
        public int InstructionsCalculs { get; set; }
        public int InstructionsEs { get; set; }
        public int Threads { get; set; }
        public string ProcessusInfo { get; set; }
        public List<Instruction> Instructions { get; set; }

        public Processus()
        {
        }

        public Processus(string nom, int priorite, int instructionsCalculs, int instructionsEs, int threads)
        {
            Pid = DateTime.UtcNow.Millisecond;
            Nom = nom;
            Priorite = priorite;
            Etat = "En attente";
            InstructionsCalculs = instructionsCalculs;
            InstructionsEs = instructionsEs;
            Threads = threads;
            ProcessusInfo = string.Format("{0}\nPID: {1}\nPriorité: {2}\nÉtat: {3}", Nom, Pid, Priorite, Etat);

            Instructions = CreateInstructions();
        }

        private List<Instruction> CreateInstructions()
        {
            List<Instruction> instructions = new List<Instruction>();

            for (int i = 0; i < InstructionsCalculs; i++)
            {
                instructions.Add(new Instruction("calcul"));
            }

            for (int i = 0; i < InstructionsEs; i++)
            {
                instructions.Add(new Instruction("es"));
            }

            return instructions;
        }
    }
}
