using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Bohater
    {
        protected int hp;
        public Bohater (int hp)
        {
            this.hp = hp;
        }
        abstract public void ZadajCios(int hp);
    }
}
