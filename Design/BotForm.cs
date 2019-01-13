using BurningBot.Network;
using BurningBot.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurningBot.Design
{
    public partial class BotForm : MetroForm
    {
        private ImageList imageList;
        private GameClient gameClient;

        public BotForm(GameClient client)
        {
            InitializeComponent();
            this.InitializeIcon();
            this.gameClient = client;
        }

        private void InitializeIcon()
        {
            imageList = new ImageList();
            imageList.Images.Add(Resources.moniteur_icon);
            imageList.Images.Add(Resources.inventaire_icon);

            this.tabControl.ImageList = this.imageList;
            this.moniteurTab.ImageIndex = 0;
            this.inventaireTab.ImageIndex = 1;

            this.tabControl.Left = this.tabControl.Left - this.tabControl.Margin.Left;
            //this.tabControl.Right = this.tabControl.Right + this.tabControl.Margin.Right - 2;

            this.tabControl.Top = this.tabControl.Top - this.tabControl.Margin.Top + 2;
            //this.tabControl.Bottom = this.tabControl.Bottom + this.tabControl.Margin.Bottom - 1;
        }

        public void SetChatMessage(int typeId, string message, string messageOwner = "")
        {
            
            Color color = Color.Red;
            string type = "Server";

            switch (typeId)
            {
                case 1:
                    color = Color.GreenYellow;
                    type = "General";
                    break;
                case 2:
                    color = Color.SaddleBrown;
                    type = "Commerce";
                    break;
                case 3:
                    color = Color.Gray;
                    type = "Recrutement";
                    break;
            }
            string textMessage = "[" + type +"] "+ messageOwner +": " + message + "\n";

            if (this.chatBox.InvokeRequired)
            {
                this.chatBox.Invoke((MethodInvoker)(() =>
                {
                    this.chatBox.SelectionColor = color;
                    this.chatBox.AppendText(textMessage);
                    this.chatBox.SelectionColor = this.chatBox.ForeColor;
                }));
            }
            else
            {
                this.chatBox.Text += textMessage;
            }
        }

        public void SetPods(int pourcentage)
        {
            if (this.podsBar.InvokeRequired)
            {
                this.podsBar.Invoke((MethodInvoker)(() =>
                {
                    this.podsBar.Value = pourcentage;
                }));
            }
            else
            {
                this.podsBar.Value = pourcentage;
            }
        }
        
        private void sendChatButton_Click(object sender, EventArgs e)
        {
            this.gameClient.SendPacket("BM*|" + this.chatBoxText.Text +"|");

            if (this.chatBoxText.InvokeRequired)
            {
                this.chatBoxText.Invoke((MethodInvoker)(() =>
                {
                    this.chatBoxText.Text = string.Empty;
                }));
            }
            else
            {
                this.chatBoxText.Text = string.Empty;
            }
        }

    }
}
