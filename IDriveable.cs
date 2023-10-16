using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class IDriveable
    {
        public ТипТранспорту Тип { get; set; }
        public double Швидкість { get; set; }
        public double Розмір { get; set; }

        public ТранспортнийЗасіб(ТипТранспорту тип, double швидкість, double розмір)
        {
            Тип = тип;
            Швидкість = швидкість;
            Розмір = розмір;
        }

        public void Рухатися()
        {
            Console.WriteLine($"Транспортний засіб типу {Тип} рухається зі швидкістю {Швидкість} км/год.");
        }

        public void Зупинитися()
        {
            Console.WriteLine($"Транспортний засіб типу {Тип} зупинився.");
        }
        interface IDriveable
        {
            void Рухатися();
            void Зупинитися();
        }

        // Клас, що імітує рух транспортних засобів
        class СимуляторРуху
        {
            public static void Main(string[] args)
            {
                Дорога дорога = new Дорога(10.0, 3.5, 2);
                ТранспортнийЗасіб авто = new ТранспортнийЗасіб(ТипТранспорту.Автомобіль, 60.0, 4.5);
                ТранспортнийЗасіб вантажівка = new ТранспортнийЗасіб(ТипТранспорту.Вантажівка, 40.0, 6.0);

                авто.Рухатися();
                вантажівка.Рухатися();

                авто.Зупинитися();
                вантажівка.Зупинитися();
            }
}
