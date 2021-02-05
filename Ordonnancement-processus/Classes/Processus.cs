using System;
using System.Collections.Generic;
using System.Text;

namespace Ordonnancement_processus.Classes
{
    public class processus
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Priorite { get; set; }
        public int Threads { get; set; }
    }
}
