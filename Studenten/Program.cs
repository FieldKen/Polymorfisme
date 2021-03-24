using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenten
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Naam = "Vincent", Leeftijd = 23 };
            Student student2 = new Student() { Naam = "Arno", Leeftijd = 26 };
            Student student3 = new Student() { Naam = "Arno", Leeftijd = 26 };
            Mens mens1 = new Mens() { Naam = "Arno", Leeftijd = 26 };


            if (student3.Equals(mens1))
            {
                Console.WriteLine("Deze zijn gelijk!");
            }
            else
            {
                Console.WriteLine("Deze zijn niet gelijk!");
            }

            Console.ReadLine();
        }
    }
}
