using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenten
{
    class Mens
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public override bool Equals(object obj)
        {
            Mens temp = obj as Mens;

            if (temp != null)
            {
                return (Leeftijd == temp.Leeftijd && Naam == temp.Naam);
            }
            return false;
        }
    }

}
