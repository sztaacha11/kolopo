using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ork:Bohater
    {
        public int walka;
        public Ork(int hp,int walka)
            : base(hp)
        {
            this.hp = hp;
            this.walka = walka;
        }
        public override void ZadajCios(int hp)
        {
            Console.WriteLine("Zadałeś cios toporem za {0} hp", hp);
        }
    }
}
