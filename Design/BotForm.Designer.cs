using BurningBot.Properties;
using System.Windows.Forms;

namespace BurningBot.Design
{
    partial class BotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotForm));
            this.lifeBar = new MetroFramework.Controls.MetroProgressBar();
            this.positionLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.moniteurTab = new System.Windows.Forms.TabPage();
            this.sendChatButton = new System.Windows.Forms.Button();
            this.chatBoxText = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.inventaireTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.podsBar = new MetroFramework.Controls.MetroProgressBar();
            this.tabControl.SuspendLayout();
            this.moniteurTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lifeBar
            // 
            this.lifeBar.Location = new System.Drawing.Point(55, 499);
            this.lifeBar.Name = "lifeBar";
            this.lifeBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.lifeBar.Size = new System.Drawing.Size(259, 18);
            this.lifeBar.Style = MetroFramework.MetroColorStyle.Green;
            this.lifeBar.TabIndex = 1;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.positionLabel.Location = new System.Drawing.Point(690, 501);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(35, 13);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "label1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.moniteurTab);
            this.tabControl.Controls.Add(this.inventaireTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(35, 46);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(6, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(742, 428);
            this.tabControl.TabIndex = 3;
            // 
            // moniteurTab
            // 
            this.moniteurTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.moniteurTab.Controls.Add(this.sendChatButton);
            this.moniteurTab.Controls.Add(this.chatBoxText);
            this.moniteurTab.Controls.Add(this.chatBox);
            this.moniteurTab.Location = new System.Drawing.Point(4, 26);
            this.moniteurTab.Name = "moniteurTab";
            this.moniteurTab.Padding = new System.Windows.Forms.Padding(3);
            this.moniteurTab.Size = new System.Drawing.Size(734, 398);
            this.moniteurTab.TabIndex = 0;
            this.moniteurTab.Text = "Moniteur";
            // 
            // sendChatButton
            // 
            this.sendChatButton.BackColor = System.Drawing.Color.White;
            this.sendChatButton.Location = new System.Drawing.Point(663, 366);
            this.sendChatButton.Name = "sendChatButton";
            this.sendChatButton.Size = new System.Drawing.Size(65, 23);
            this.sendChatButton.TabIndex = 2;
            this.sendChatButton.Text = "Send";
            this.sendChatButton.UseVisualStyleBackColor = false;
            this.sendChatButton.Click += new System.EventHandler(this.sendChatButton_Click);
            // 
            // chatBoxText
            // 
            this.chatBoxText.Location = new System.Drawing.Point(10, 367);
            this.chatBoxText.Name = "chatBoxText";
            this.chatBoxText.Size = new System.Drawing.Size(647, 20);
            this.chatBoxText.TabIndex = 1;
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.ForeColor = System.Drawing.SystemColors.Info;
            this.chatBox.Location = new System.Drawing.Point(10, 9);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(712, 351);
            this.chatBox.TabIndex = 0;
            this.chatBox.Text = "";
            // 
            // inventaireTab
            // 
            this.inventaireTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.inventaireTab.Location = new System.Drawing.Point(4, 26);
            this.inventaireTab.Name = "inventaireTab";
            this.inventaireTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventaireTab.Size = new System.Drawing.Size(734, 398);
            this.inventaireTab.TabIndex = 1;
            this.inventaireTab.Text = "Inventaire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BurningBot.Properties.Resources.inventaire_icon;
            this.pictureBox2.Location = new System.Drawing.Point(336, 492);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 34);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // podsBar
            // 
            this.podsBar.Location = new System.Drawing.Point(376, 498);
            this.podsBar.Name = "podsBar";
            this.podsBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.podsBar.Size = new System.Drawing.Size(259, 18);
            this.podsBar.Style = MetroFramework.MetroColorStyle.Green;
            this.podsBar.TabIndex = 5;
            // 
            // BotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.podsBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.lifeBar);
            this.MaximizeBox = false;
            this.Name = "BotForm";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabControl.ResumeLayout(false);
            this.moniteurTab.ResumeLayout(false);
            this.moniteurTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar lifeBar;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TabPage moniteurTab;
        private System.Windows.Forms.TabPage inventaireTab;
        public System.Windows.Forms.TabControl tabControl;
        public RichTextBox chatBox;
        private Button sendChatButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MetroFramework.Controls.MetroProgressBar podsBar;
        public TextBox chatBoxText;
    }
}