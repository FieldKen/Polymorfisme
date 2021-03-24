using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Politiek
{
    class EersteMinister
    {
        public List<Minister> Ministers = new List<Minister>();

        public EersteMinister()
        {
            Ministers.Add(new MinisterVanMilieu());
            Ministers.Add(new MinisterBZ());
            Ministers.Add(new MinisterVanEconomie());
        }

        public void Regeer()
        {
            foreach (var minister in Ministers)
            {
                minister.Adviseer();
            }
        }


        /*public MinisterVanMilieu Gawein { get; set; } = new MinisterVanMilieu();
        public MinisterBZ Claire { get; set; } = new MinisterBZ();
        public MinisterVanEconomie Tom { get; set; } = new MinisterVanEconomie();

        public void Regeer()
        {
            Gawein.Adviseer();
            Claire.Adviseer();
            Tom.Adviseer();
        }*/

    }
}
