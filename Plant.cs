using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Plant
    {
        public class Plant : LivingOrganism, IReproducible
        {
            public void Reproduce()
            {
                Energy -= 5;
                // Логіка розмноження рослин
            }
        }
    }
}
