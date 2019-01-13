using BurningBot.Common.Frames.Dispatcher;
using BurningBot.Network;
using BurningBot.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Game
{
    class ServerSelectionFrame : Frame
    {
        [PacketId("HG")]
        public void HelloGame(GameClient client, string packet)
        {
            client.SendPacket("AT" + client.Guid);
        }

        [PacketId("ATK0")]
        public void ServerSelectionSuccess(GameClient client, string packet)
        {
            client.SendPacket("Ak0");
            client.SendPacket("AV");
        }

        [PacketId("AV0")]
        public void CharactersList(GameClient client, string packet)
        {
            client.SendPacket("Agfr");
            client.SendPacket("Ai" + Hash.GenerateString(15));
            client.SendPacket("AL");
            client.SendPacket("Af");
        }

        [PacketId("ALK")]
        public void CharacterSelection(GameClient client, string packet)
        {
            var parsedPacket = packet.Split('|');
            foreach(var character in parsedPacket.Where((source, index) => index > 1).ToArray())
            {
                var characterInformations = character.Split(';');
                if(characterInformations[1] == "Mixite")
                {
                    client.SendPacket("AS" + characterInformations[0]);
                    client.SendPacket("Af");

                    //init de mon design:
                    client.BotManager.InitializeInformationsForm();
                    
                    break;
                }
            }
        }
    }
}
