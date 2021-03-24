using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class MinisterVanMilieu : Minister
    {
        public override void Adviseer()
        {
            PlantBomen();
            AdopteerDieren();
            Staken();
        }

        private void PlantBomen()
        {
            Console.WriteLine("De minister van milieu plant bomen");
        }

        private void AdopteerDieren()
        {
            Console.WriteLine("De minister van milieu adopteert dieren");
        }

        private void Staken()
        {
            Console.WriteLine("De minister van milieu staakt");
        }
    }
}
