using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class MinisterVanEconomie : Minister
    {
        public override void Adviseer()
        {
            GeldIncasseren();
            GeldVerbranden();
        }

        private void GeldVerbranden()
        {
            Console.WriteLine("De minister van economie verbrand geld");
        }

        private void GeldIncasseren()
        {
            Console.WriteLine("De minister van economie incasseert geld");
        }
    }
}
