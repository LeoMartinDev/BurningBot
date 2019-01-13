using System;

namespace BurningBot.Common.Frames.Dispatcher
{
    internal class PacketIdAttribute : Attribute
    {
        public string Value;

        public PacketIdAttribute(string v)
        {
            this.Value = v;
        }
    }
}