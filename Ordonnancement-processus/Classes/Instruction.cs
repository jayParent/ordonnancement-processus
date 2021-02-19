using System;
using System.Collections.Generic;
using System.Text;

namespace Ordonnancement_processus.Classes
{
    public class Instruction
    {
        public string Type { get; set; }
        public int Temps { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }

        public Instruction(string type, int row, int col)
        {
            Type = type;
            Row = row;
            Col = col;

            if (type == "calcul")
                Temps = 1;
            else if (type == "es")
                Temps = 3;
        }
    }
}
