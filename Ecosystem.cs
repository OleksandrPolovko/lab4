using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Ecosystem
    {
        public class Ecosystem
        {
            private List<LivingOrganism> organisms;

            public Ecosystem()
            {
                organisms = new List<LivingOrganism>();
            }

            public void AddOrganism(LivingOrganism organism)
            {
                organisms.Add(organism);
            }
            public void SimulateEcosystem(int numIterations)
    {
        for (int i = 0; i < numIterations; i++)
        {
            // Логіка взаємодії між організмами: харчування, розмноження, конкуренція
            foreach (var organism in organisms)
            {
                if (organism.IsAlive())
                {
                    if (organism is IReproducible reproducibleOrganism)
                    {
                        reproducibleOrganism.Reproduce();
                    }

                    if (organism is IPredator predator)
                    {
                        foreach (var prey in organisms.Where(o => o != organism && o.IsAlive()))
                        {
                            predator.Hunt(prey);
                        }
                    }

                    organism.Grow();
        }
    }
