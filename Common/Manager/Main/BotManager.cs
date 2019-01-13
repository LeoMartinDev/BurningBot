using BurningBot.Design;
using BurningBot.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurningBot.Common.Manager.Main
{
    public class BotManager
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public BotForm Informations { get; set; }
        private AuthClient AuthClient { get; set; }
        private GameClient GameClient { get; set; }

        public BotManager(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.AuthClient = new AuthClient(this, "34.251.172.139", 443);
        }

        public void SwitchToGameServer(string ipAdresse, string guid)
        {
            this.GameClient = new GameClient(this, ipAdresse, 443, guid);
        }

        public void InitializeInformationsForm()
        {
            this.Informations = new BotForm(GameClient);
            Task.Run(() => this.Informations.ShowDialog());
        }
    }
}
