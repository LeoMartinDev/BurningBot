using BurningBot.Common.Manager.Main;
using BurningBot.Common.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
namespace BurningBot.Network
{
    class AuthClient : AbstractClient
    {
        public AuthClient(BotManager botManager, string ipAdresse, int port):base(botManager, ipAdresse, port) { }

        public override void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;
            Socket handler = (Socket)ar.AsyncState;
            
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                var data = Encoding.UTF8.GetString(this.Buffer, 0, bytesRead);
              
                foreach (var packet in data.Replace("\x0a", string.Empty).Split('\x00').Where(x => x != ""))
                {
                    Console.WriteLine(packet);
                    Program.packetReceiver.Receive(this, packet);
                }
              
            }
            this.Socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, 0, new AsyncCallback(ReadCallback), this.Socket);
        }
    }
}
