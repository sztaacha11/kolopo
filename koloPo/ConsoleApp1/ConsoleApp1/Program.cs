using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Magazyn> Kolejka = new Queue<Magazyn>();
            Kolejka.Enqueue(new Magazyn("a"));
            Kolejka.Enqueue(new Magazyn("b"));
            Kolejka.Enqueue(new Magazyn("c"));
            Console.WriteLine(Kolejka.Dequeue());
            Console.WriteLine(Kolejka.Dequeue());
            Console.WriteLine(Kolejka.Dequeue());
            List<Magazyn> Lista = new List<Magazyn>();
            Lista.Add(new Magazyn("Nowy"));
            Lista.Add(new Magazyn("Stary"));
            Lista.Add(new Magazyn("Duzy"));
            Lista.Reverse();
            Lista.Sort((x, y) => string.Compare(x.zamowienie, y.zamowienie));
            List<Bohater> Bohaterowie = new List<Bohater>();
            Bohaterowie.Add(new Ork(200,100));
            Bohaterowie.Add(new Ork(210,300));
            Bohaterowie.Add(new Elf(80, "Błyskawica"));
            Bohaterowie.Add(new Elf(40, "Kula Ognia"));
            foreach (var item in Bohaterowie)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
