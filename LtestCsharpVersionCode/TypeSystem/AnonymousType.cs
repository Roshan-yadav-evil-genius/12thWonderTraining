using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LtestCsharpVersionCode.TypeSystem
{
    internal class AnonymousType
    {
        public void Execute()
        {
            var packet = new
            {
                sender = "RoshanYadav",
                Message = "Hello",
                receiver = "satyam",
                priority = 100,
                metaData = new
                {
                    senderIp = "192.168.27",
                    receiverIp = "192.274.78"
                }
            };

            Console.WriteLine(packet);
            Console.WriteLine(packet.sender);

        }
    }
}
