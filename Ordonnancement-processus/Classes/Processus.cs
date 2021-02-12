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
        public int InstructionsCalculs { get; set; }
        public int InstructionsEs { get; set; }
        public int Threads { get; set; }
        public List<Instruction> Instructions { get; set; }
        public Random random = new Random();

        public Processus()
        {
        }

        public Processus(string nom, int priorite, int instructionsCalculs, int instructionsEs, int threads)
        {
            Pid = DateTime.UtcNow.Millisecond * random.Next(1, 100) - random.Next(1, 1000);
            Nom = nom;
            Priorite = priorite;
            InstructionsCalculs = instructionsCalculs;
            InstructionsEs = instructionsEs;
            Threads = threads;
        }

        public void CreateTable()
        {
            
        }
    }
}
