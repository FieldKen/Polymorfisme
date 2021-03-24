using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    abstract class Dier
    {
        public abstract string MaakGeluid();
    }

    class Paard : Dier
    {
        public override string MaakGeluid()
        {
            return "Hihihinnik prrrt";
        }
    }

    class Varken : Dier
    {
        public override string MaakGeluid()
        {
            return "Oink";
        }
    }
}
