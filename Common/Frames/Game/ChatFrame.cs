using BurningBot.Common.Frames.Dispatcher;
using BurningBot.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Game
{
    class ChatFrame : Frame
    {
        [PacketId("Im189")]
        public void MessageBienvenue(GameClient client, string packet)
        {
            //Server
            client.BotManager.Informations.SetChatMessage(0, "Bienvenue sur DOFUS, dans le Monde des Douze !");
        }

        [PacketId("cMK")]
        public void ChatMessage(GameClient client, string packet)
        {
            var parsedPacket = packet.Split('|');
            switch (parsedPacket[0])
            {
                case "cMK":
                    //General
                    client.BotManager.Informations.SetChatMessage(1, parsedPacket[3], parsedPacket[2]);
                    break;
                case "cMK:":
                    //Commerce
                    client.BotManager.Informations.SetChatMessage(2, parsedPacket[3], parsedPacket[2]);
                    break;
                case "cMK?":
                    //Recrutement
                    client.BotManager.Informations.SetChatMessage(3, parsedPacket[3], parsedPacket[2]);
                    break;
            }
        }
    }
}
