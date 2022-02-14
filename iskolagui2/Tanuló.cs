using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iskolagui2
{
    class Tanuló
    {
        public int Év { get; set; }
        public string Osztály { get; set; }
        public string Név { get; set; }

        public Tanuló(string sor)
        {
            string[] t = sor.Split(';');
            Év = int.Parse(t[0]);
            Osztály = t[1];
            Név = t[2];
        }
    }
}
