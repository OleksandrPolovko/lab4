using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal interface IConnectable
    {
        public interface IConnectable
        {
            void Connect(Computer targetComputer);
            void Disconnect(Computer targetComputer);
            void SendData(string data, Computer targetComputer);
            void ReceiveData(string data, Computer sourceComputer);
        }
    }
}
