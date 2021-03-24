using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Varken());
            dieren.Add(new Paard());

            foreach (var dier in dieren)
            {
                Console.WriteLine(dier.MaakGeluid());
            }

            Console.ReadLine();

            //Paard paard = new Paard();
            //Varken varken = new Varken();

            //Console.WriteLine(paard.MaakGeluid());
            //Console.WriteLine(varken.MaakGeluid());
            //Console.ReadLine();
        }
    }
}
