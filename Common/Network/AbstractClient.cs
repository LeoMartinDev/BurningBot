using BurningBot.Common.Manager.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Network
{
    public class AbstractClient
    {
        public Socket Socket { get; set; }
        public byte[] Buffer { get; set; }
        public BotManager BotManager { get; set; }

        public AbstractClient(BotManager botManager, string ipAdresse, int port)
        {
            this.Buffer = new byte[1024];
            this.BotManager = botManager;
            this.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.Socket.BeginConnect(IPAddress.Parse(ipAdresse), port, new AsyncCallback(this.ConnectCallback), this.Socket);
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            Socket client = (Socket)ar.AsyncState;
            client.EndConnect(ar);
            this.Socket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, new AsyncCallback(ReadCallback), client);
        }

        public virtual void ReadCallback(IAsyncResult ar) { }

        public void SendPacket(string packet)
        {
            this.Socket.Send(Encoding.UTF8.GetBytes(string.Format("{0}\n\x00", packet)));
            Console.WriteLine("Send: " + packet);
        }
    }
}
