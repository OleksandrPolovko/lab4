using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class LivingOrganism
    {
        public int Energy { get; set; }
        public int Age { get; set; }
        public int Size { get; set; }

    }
    public void Grow();

        {   
          Age++;
          Energy -= 2;
        }

    public bool IsAlive();

      { 
         return Energy > 0 && Age < 100; 
      }
        

}
    
