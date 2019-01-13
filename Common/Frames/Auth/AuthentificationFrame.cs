using BurningBot.Common.Frames.Dispatcher;
using BurningBot.Network;
using BurningBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Auth
{
    class AuthentificationFrame : Frame
    {
        [PacketId("HC")]
        public void Connection(AuthClient client, string packet)
        {
            var key = packet.Substring(2, 32);

            client.SendPacket("1.29.1");
            client.SendPacket(client.BotManager.Username + "\n"+ Hash.Encrypt(client.BotManager.Password, key));
            client.SendPacket("Af");
        }

        [PacketId("AQ")]
        public void AuthentificationSuccess(AuthClient client, string packet)
        {
            client.SendPacket("Ax");
        }

        [PacketId("AxK")]
        public void ServerList(AuthClient client, string packet)
        {
            client.SendPacket("AX601");
        }

        [PacketId("AXK")]
        public void ServerSelection(AuthClient client, string packet)
        {
            var serverIp = Hash.DecryptIP(packet.Substring(3));
            var guid = packet.Substring(packet.Length - 7, 7);

            //faire le switch au game server:
            client.BotManager.SwitchToGameServer(serverIp, guid);
        }
    }
}
