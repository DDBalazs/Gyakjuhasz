using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Gyakjuhasz
{
    internal class Versenyzo
    {
        public string Nev { get; set; }
        public int RajtSzam { get; set; }
        public string Kategoria { get; set; }
        public string Idoeredmeny { get; set; }
        public int TavSzazalek { get; set; }

        public Versenyzo(string fileEgySora)
        {
            string[] aFileSorainakDarabjai = fileEgySora.Split(';');
            this.Nev = aFileSorainakDarabjai[0];
            this.RajtSzam = int.Parse(aFileSorainakDarabjai[1]);
            this.Kategoria = aFileSorainakDarabjai[2];
            this.Idoeredmeny = aFileSorainakDarabjai[3];
            this.TavSzazalek = int.Parse(aFileSorainakDarabjai[4]);
        }
    }
}
