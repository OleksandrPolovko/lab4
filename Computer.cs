using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Computer
    {
        public class Computer
        {
            public string IPAddress { get; set; }
            public int Power { get; set; }
            public string OperatingSystem { get; set; }

            public void Connect(Computer targetComputer)
            {
                // Логіка з'єднання
            }

            public void Disconnect(Computer targetComputer)
            {
                // Логіка відключення
            }

            public void SendData(string data, Computer targetComputer)
            {
                // Логіка передачі даних
            }

            public void ReceiveData(string data, Computer sourceComputer)
            {
                // Логіка отримання даних
            }
        }
    }
}
