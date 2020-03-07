using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP25
{
    class Program
    {
        static void Main(string[] args)
        {
            Magician m = new Magician("Tomy", 1987, "Cards Spell");

            Magician m4 = new Magician("Mike", 2002, "Cards Spell");

          
            RoundTable<Magician> m2 = new RoundTable<Magician>();
            m2.Add(new Magician("Jack", 2008, "Cards Spell"));
            m2.Add(new Magician("Tomy", 1987, "Cards Spell"));
            m2.Add(new Magician("Mike", 2002, "Cards Spell"));

            foreach (Magician item in m2)
            {
                Console.WriteLine(item);
            }
         }
    }
}
