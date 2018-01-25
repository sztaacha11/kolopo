using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Elf:Bohater
    {
        public string Magia;
        public Elf(int hp,string magia)
            : base(hp)
        {
            this.hp = hp;
            this.Magia = magia;
        }
        public override void ZadajCios(int hp)
        {
            Console.WriteLine("Rzuciłeś zaklęcie za {0} hp", hp);
        }
    }
}
