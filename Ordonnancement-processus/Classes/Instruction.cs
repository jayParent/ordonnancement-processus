using System;
using System.Collections.Generic;
using System.Text;

namespace Ordonnancement_processus.Classes
{
    public class Instruction
    {
        public string Type { get; set; }
        public int Temps { get; set; }

        public Instruction(string type)
        {
            Type = type;

            if (type == "calcul")
                Temps = 1;
            else if (type == "es")
                Temps = 3;
        }
    }
}
