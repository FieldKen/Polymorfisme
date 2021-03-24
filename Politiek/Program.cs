using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class Program
    {
        static void Main(string[] args)
        {
            EersteMinister katia = new EersteMinister();
            katia.Regeer();
            Console.ReadLine();
        }
    }
}
