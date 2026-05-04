using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrandC
{
    internal class Furdok
    {
        public class Furdo
        {
            public string Név { get; private set; }

            public string Cim { get; private set; }

            public int Ár  { get; private set; }

            public int Vizhőfok { get; private set; }

            // Gyulai Várfurdő;5700
            public Furdo(string sor) {

                string[] adatok = sor.Split(',');
                Név = adatok[0];
                Cim = adatok[1];
                Ár = int.Parse(adatok[2]);
                Vizhőfok = int.Parse(adatok[3]);    
            }
            public string IRSZ()
            {
                return Cim.Split(',')[0];
            }
            public String Telepules()
            {
                return Cim.Split(',')[1];   
            }
        }
    }
}
