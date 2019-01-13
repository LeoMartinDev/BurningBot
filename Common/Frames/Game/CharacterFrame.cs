using BurningBot.Common.Frames.Dispatcher;
using BurningBot.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Game
{
    class CharacterFrame : Frame
    {
        [PacketId("Ow")]
        public void UpdatePods(GameClient client, string packet)
        {
            var pods = packet.Substring(2).Split('|');
           
            int podsActuel = int.Parse(pods[0]);
            int podsMax = int.Parse(pods[1]);
            client.BotManager.Informations.SetPods(BurningBot.Utils.Math.Pourcentage(podsActuel, podsMax));
        }
    }
}
