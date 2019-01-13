using BurningBot.Common.Network;
using BurningBot.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Frames.Dispatcher
{
    class PacketReceiver
    {
        private bool IsInitialized { get; set; }
        private List<PacketData> Methods { get; set; }

        public PacketReceiver()
        {
            this.Methods = new List<PacketData>();
            this.IsInitialized = false;
        }

        public void Initialize()
        {
            if (!this.IsInitialized)
            {
                Assembly assembly = typeof(Frame).GetTypeInfo().Assembly;
                foreach(var type in assembly.GetTypes().SelectMany(x => x.GetMethods()).Where(m => m.GetCustomAttributes(typeof(PacketIdAttribute), false).Length > 0).ToArray())
                {
                    PacketIdAttribute attr = (PacketIdAttribute)type.GetCustomAttributes(typeof(PacketIdAttribute), true)[0];
                    Type stringType = Type.GetType(type.DeclaringType.FullName);

                    var instance = Activator.CreateInstance(stringType, null); // instance d'une methode
                
                    Methods.Add(new PacketData(instance, attr.Value, type));
                }

                this.IsInitialized = true;
                Console.WriteLine("Initialized !");
            }
        }

        public void Receive(AbstractClient client, string packet)
        {
            if (!this.IsInitialized)
                this.Initialize();
            
            foreach(var method in Methods)
            {
                if (packet.StartsWith(method.Key))
                {
                    method.Methode.Invoke(method.Instance, new object[] { client, packet });
                    break;
                }
            }
        }

    }
}
