using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooverwaltung.Models
{
    public class Betreut
    {
        public int GehegeID { get; set; }
        public int PflegerID { get; set; }
        public bool Hauptpfleger { get; set; }
    }
}

