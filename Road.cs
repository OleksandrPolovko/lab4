using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Road
    {
        public double Довжина { get; set; }
        public double Ширина { get; set; }
        public int КількістьСмуг { get; set; }
        public int РівеньТрафіку { get; set; }

        public Дорога(double довжина, double ширина, int кількістьСмуг)
        {
            Довжина = довжина;
            Ширина = ширина;
            КількістьСмуг = кількістьСмуг;
            РівеньТрафіку = 0;
        }
        // Перелік можливих типів транспортних засобів
        enum ТипТранспорту
        {
            Автомобіль,
            Вантажівка,
            Автобус
        }
    }
}
