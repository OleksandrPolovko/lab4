using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Ecosystem ecosystem = new Ecosystem();

                Animal lion = new Animal();
                Animal deer = new Animal();
                Plant grass = new Plant();
                Microorganism bacteria = new Microorganism();

                ecosystem.AddOrganism(lion);
                ecosystem.AddOrganism(deer);
                ecosystem.AddOrganism(grass);
                ecosystem.AddOrganism(bacteria);

                ecosystem.SimulateEcosystem(100);

                // Виведення результатів моделювання
                foreach (var organism in ecosystem)
                {
                    Console.WriteLine($"Energy: {organism.Energy}, Age: {organism.Age}, Size: {organism.Size}");
                }
            }
    }
}
