using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voertuigen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> alleVoertuigen = new List<Object>();
            alleVoertuigen.Add(new Auto());
            alleVoertuigen.Add(new Auto());
            alleVoertuigen.Add(new Voertuig());
            alleVoertuigen.Add(new Voertuig());
            alleVoertuigen.Add(new Persoon());

            foreach (var item in alleVoertuigen)
            {
                if (item is Auto)
                {
                    Console.WriteLine("Dit is een auto");
                }
                
                if (item is Voertuig)
                {
                    Console.WriteLine("Dit is een voertuig");
                }
                
                if (item is Persoon)
                {
                    Console.WriteLine("Wa doet gij in mijn List?");
                }
            }

            Console.ReadLine();

            Auto auto = new Auto();
            Persoon nick = new Persoon();

            if (auto is Voertuig)
            {
                Console.WriteLine("Auto is een voertuig");
            }

            if (nick is Voertuig)
            {
                Console.WriteLine("Nick is een voertuig");
            }

            Console.ReadLine();
        }
    }
}
