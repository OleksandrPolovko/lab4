using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Network
    {
        public class Network
        {
            private List<Computer> computers = new List<Computer>();

            public void AddComputer(Computer computer)
            {
                computers.Add(computer);
            }

            public void ConnectComputers(Computer computer1, Computer computer2)
            {
                computer1.Connect(computer2);
            }

            public void DisconnectComputers(Computer computer1, Computer computer2)
            {
                computer1.Disconnect(computer2);
            }

            public void SimulateDataTransfer(Computer sourceComputer, Computer targetComputer, string data)
            {
                sourceComputer.SendData(data, targetComputer);
                targetComputer.ReceiveData(data, sourceComputer);
            }
        }
    }
}
