using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabazeAppPereverten.data
{
    public class MotorovaVozidla : InterfaceAuta
    {
        //TODO metoda pro overovani vstupu
        public Palivo palivo { get; set; }
        public Znacka znacka { get; set; }
        public bool jeSpravny { get; set; }
        public bool jeNastartovany { get; set; }

        public MotorovaVozidla(Palivo palivo, Znacka znacka, bool jeSpravny, bool jeNastartovany)
        {
            this.palivo = palivo;
            this.znacka = znacka;
            this.jeSpravny = jeSpravny;
            this.jeNastartovany = jeNastartovany;
        }
        //TODO vsechno de je konsole writelene zamenit na messagebox
        public void Signal() 
        {
            if (jeNastartovany)
            {
                Console.WriteLine("Bip");
                MessageBox.Show("Bip!");
            }
            else 
            {
                Console.WriteLine("Neni nastartovane");
                MessageBox.Show("Neni nastartovane");
            }
        }

        public void Nastartovat() 
        {
            if (jeSpravny && !jeNastartovany) {
                jeNastartovany = true;
                Console.WriteLine("Je nastartovane");
            } else if (jeNastartovany)
            {
                Console.WriteLine("Uz je nastartovane");
            }
            else 
            {
                Console.WriteLine("Neni spravne vozidlo");
            }
        }

        public override string ToString()
        {
            return $"Motorove vozidlo znacky {znacka}";
        }
    }
}
