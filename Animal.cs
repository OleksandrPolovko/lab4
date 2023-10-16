using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Animal
    {
        public class Animal : LivingOrganism, IReproducible, IPredator
       public void Reproduce()
        {
            Energy -= 20;
            // Логіка розмноження тварин
        }
        public void Hunt(LivingOrganism prey)
        {
            Energy += 10;
            // Логіка полювання тварин
        }
    }


}
}
