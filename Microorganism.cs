using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Microorganism
    {
        public class Microorganism : LivingOrganism, IReproducible
        {
            public void Reproduce()
            {
                Energy -= 1;
                // Логіка розмноження мікроорганізмів
            }
        }
    }
}
