using BurningBot.Common.Frames.Dispatcher;
using BurningBot.Common.Manager.Map;
using BurningBot.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Game
{
    class MapFrame : Frame
    {
        [PacketId("al")]
        public void SubArea(GameClient client, string packet)
        {
            client.SendPacket("GC1");
        }

        [PacketId("fC")]
        public void FightNumberOnMap(GameClient client, string packet)
        {
            client.SendPacket("BD");
        }

        //connais pas ce packet:
        [PacketId("BD")]
        public void BD(GameClient client, string packet)
        {
            client.SendPacket("GI");
        }

        [PacketId("GDM")]
        public void InformationsMap(GameClient client, string packet)
        {
            //MAP informations:
            Map map = new Map(client, packet);
        }
    }
}
