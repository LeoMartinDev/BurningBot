using BurningBot.Common.Frames.Dispatcher;
using BurningBot.Common.Manager.Main;
using BurningBot.Design;
using BurningBot.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot
{
    class Program
    {
        public static PacketReceiver packetReceiver;

        static void Main(string[] args)
        {
            packetReceiver = new PacketReceiver();
            packetReceiver.Initialize();

            BotManager botManager = new BotManager("selim59150", "Mirabelle29");
            
            Console.ReadKey();
        }
    }
}
