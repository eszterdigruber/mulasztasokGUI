using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mulasztasokGUI
{
    internal class Mulasztas
    {
        string nev;
        string osztaly;
        string hanyadika;
        int igazolt;
        int nemigazolt;

        public string Nev { get => nev; set => nev = value; }
        public string Osztaly { get => osztaly; set => osztaly = value; }
        public string Hanyadika { get => hanyadika; set => hanyadika = value; }
        public int Igazolt { get => igazolt; set => igazolt = value; }
        public int Nemigazolt { get => nemigazolt; set => nemigazolt = value; }

        public Mulasztas(string sor)
        {
            string[] darabok = sor.Split(';');
            nev = darabok[0];
            osztaly = darabok[1];
            hanyadika = darabok[2];
            igazolt = Convert.ToInt32(darabok[3]);
            nemigazolt = Convert.ToInt32(darabok[4]);
        }

        public int NapiHianyzasSzamolas()
        {
            return igazolt + nemigazolt;
        }
    }
}
