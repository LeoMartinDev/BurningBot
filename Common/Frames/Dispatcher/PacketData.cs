using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Dispatcher
{
    public class PacketData
    {
        public object Instance;
        public string Key;
        public MethodInfo Methode;

        public PacketData(object instance, string key, MethodInfo method)
        {
            this.Instance = instance;
            this.Key = key;
            this.Methode = method;
        }
    }
}
