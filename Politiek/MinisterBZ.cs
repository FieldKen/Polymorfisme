using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class MinisterBZ :Minister
    {
        public override void Adviseer()
        {
            PoenPakken();
            Graaien();
            KoffieDrinken();
        }

        private void PoenPakken()
        {
            Console.WriteLine("De minister van BZ pakt poen");
        }

        private void Graaien()
        {
            Console.WriteLine("De minister van BZ graait");
        }

        private void KoffieDrinken()
        {
            Console.WriteLine("De minister van BZ drinkt koffie");
        }
    }
}
