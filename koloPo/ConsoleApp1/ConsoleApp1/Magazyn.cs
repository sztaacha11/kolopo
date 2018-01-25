using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Magazyn
        { 
        public string zamowienie;

        public Magazyn(string zamowienie)
        {
            this.zamowienie = zamowienie;
        }
        public bool Przyjmij(string zamowienie)
        {
            return true;
        }
        public bool Wydaj(string zamowienie)
        {
            return true;
        }
    }
}
