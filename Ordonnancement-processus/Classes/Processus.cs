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
        public bool Termine { get; set; }
        public int InstructionsCalculs { get; set; }
        public int InstructionsEs { get; set; }
        public int InstructionsTotal { get; set; }
        public int InstructionCourante { get; set; }
        public int Threads { get; set; }
        public int ThreadN { get; set; }
        public int Col { get; set; }
        public string ProcessusInfo { get; set; }
        public List<Instruction> Instructions { get; set; }
        private static Random random = new Random();

        // Constructeur sans threads
        public Processus(int pid, string nom, int priorite, int instructionsCalculs, int instructionsEs, int threads)
        {
            Pid = pid;
            Nom = nom;
            Priorite = priorite;
            Etat = "En attente";
            Termine = false;
            InstructionsCalculs = instructionsCalculs;
            InstructionsEs = instructionsEs;
            InstructionsTotal = InstructionsCalculs + InstructionsEs;
            InstructionCourante = 0;
            Threads = threads;
            Col = Pid;
            ProcessusInfo = string.Format("{0}\nPID: {1}\nPriorité: {2}\nÉtat: {3}", Nom, Pid, Priorite, Etat);
            Instructions = CreateInstructions();

            //List<Instruction> instructions = CreateInstructions();
            //Instructions = ShuffleInstructions(instructions);
        }

        // Constructeur avec threads
        public Processus(int pid, int threadN, string nom, int priorite, int instructionsCalculs, int instructionsEs)
        {
            Pid = pid;
            ThreadN = threadN;
            Nom = nom;
            Priorite = priorite;
            Etat = "En attente";
            InstructionsCalculs = instructionsCalculs;
            InstructionsEs = instructionsEs;
            InstructionsTotal = InstructionsCalculs + InstructionsEs;
            InstructionCourante = 0;
            Col = ThreadN;
            ProcessusInfo = string.Format("{0}\nPID: {1}\nThread: {4}\nPriorité: {2}\nÉtat: {3}", Nom, Pid, Priorite, Etat, ThreadN);
            Instructions = CreateInstructions();
        }

        private List<Instruction> CreateInstructions()
        {
            List<Instruction> instructions = new List<Instruction>();
            int row = 0;

            for (int i = 0; i < InstructionsCalculs; i++)
            {
                instructions.Add(new Instruction("calcul", row, Col, Pid));
                row += 1;
            }

            for (int i = 0; i < InstructionsEs; i++)
            {
                instructions.Add(new Instruction("es", row, Col, Pid));
                row += 1;
            }

            return instructions;
        }

        public List<Instruction> ShuffleInstructions(List<Instruction> instructions)
        {
            int n = instructions.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Instruction value = instructions[k];
                instructions[k] = instructions[n];
                instructions[n] = value;
            }

            return instructions;
        }
    }
}
