using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Osoba
    {
        string Jmeno { get; set; }
        string Prijmeni { get; set; }
        public DateTime DatumNarození { get; set; }

        public string Vek()
        {
            DateTime = dnes = DateTime.Now;
            return ((dnes - DatumNarození).ToString());
        }
    


    }
}
