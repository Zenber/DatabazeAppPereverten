using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeAppPereverten.data
{
    public class Motocykl : MotorovaVozidla
    {
        public Motocykl(Palivo palivo, Znacka znacka, bool jeSpravny, bool jeNastartovany) : base(palivo, znacka, jeSpravny, jeNastartovany)
        {
        }
    }
}
