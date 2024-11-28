using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeAppPereverten.data
{
    public class Auto : MotorovaVozidla
    {
        PocetDvere pocetDvere { get; set; }
        public Auto(Palivo palivo, Znacka znacka, bool jeSpravny, bool jeNastartovany, PocetDvere pocet) : base(palivo, znacka, jeSpravny, jeNastartovany)
        {
            pocetDvere = pocet;
        }
        public Auto(Palivo palivo, Znacka znacka, bool jeSpravny, bool jeNastartovany) : base(palivo, znacka, jeSpravny, jeNastartovany)
        {
            
        }

        public static List<Auto> GenereteAuta() {
            List<Auto> list = new List<Auto>();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++) 
            {
                int rPalivo = rnd.Next(1, 3);
                int rNastartovany = rnd.Next(1, 3);
                int rZnacka = rnd.Next(1, 6);
                int rSpravny = rnd.Next(1,3);

                Palivo palivo = new Palivo();
                Znacka znacka = new Znacka();
                bool jeSpravny = false;
                bool jeNastartovany = false;

                // 1 znamena true, 2 znamena false
                if (rSpravny == 2) {
                    rNastartovany = rSpravny;
                }

                switch (rPalivo) 
                {
                    case 1:
                        palivo = data.Palivo.Benzin;
                        break;
                    case 2:
                        palivo = data.Palivo.Disel;
                        break;
                }
                switch (rSpravny)
                {
                    case 1:
                        jeSpravny = true;
                        break;
                    case 2:
                        jeSpravny = false;
                        break;
                }
                switch (rNastartovany)
                {
                    case 1:
                        jeNastartovany = true;
                        break;
                    case 2:
                        jeNastartovany = false;
                        break;
                }
                switch (rNastartovany)
                {
                    case 1:
                        jeNastartovany = true;
                        break;
                    case 2:
                        jeNastartovany = false;
                        break;
                }
                switch (rZnacka)
                {
                    case 1:
                        znacka = data.Znacka.Skoda;
                        break;
                    case 2:
                        znacka = data.Znacka.Opel;
                        break;
                    case 3:
                        znacka = data.Znacka.Reno;
                        break;
                    case 4:
                        znacka = data.Znacka.Audi;
                        break;
                    case 5:
                        znacka = data.Znacka.BMW;
                        break;

                }
                list.Add(new Auto(palivo,znacka,  jeSpravny, jeNastartovany));
            }
            return list;
        }

    }
}
