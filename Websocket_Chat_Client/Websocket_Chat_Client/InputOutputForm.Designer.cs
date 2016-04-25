namespace Websocket_Chat_Client
{
    partial class InputOutputForm
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
            this.uxTextbox = new System.Windows.Forms.RichTextBox();
            this.uxSendButton = new System.Windows.Forms.Button();
            this.uxChat = new System.Windows.Forms.ListBox();
            this.uxContactList = new System.Windows.Forms.ListBox();
            this.uxChatScrollBar = new System.Windows.Forms.VScrollBar();
            this.uxContactScroll = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTextbox
            // 
            this.uxTextbox.Enabled = false;
            this.uxTextbox.Location = new System.Drawing.Point(8, 621);
            this.uxTextbox.Name = "uxTextbox";
            this.uxTextbox.Size = new System.Drawing.Size(658, 96);
            this.uxTextbox.TabIndex = 0;
            this.uxTextbox.Text = "";
            // 
            // uxSendButton
            // 
            this.uxSendButton.Enabled = false;
            this.uxSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.uxSendButton.Location = new System.Drawing.Point(672, 621);
            this.uxSendButton.Name = "uxSendButton";
            this.uxSendButton.Size = new System.Drawing.Size(117, 96);
            this.uxSendButton.TabIndex = 1;
            this.uxSendButton.Text = "Send";
            this.uxSendButton.UseVisualStyleBackColor = true;
            // 
            // uxChat
            // 
            this.uxChat.Enabled = false;
            this.uxChat.FormattingEnabled = true;
            this.uxChat.ItemHeight = 20;
            this.uxChat.Location = new System.Drawing.Point(210, 45);
            this.uxChat.Name = "uxChat";
            this.uxChat.Size = new System.Drawing.Size(578, 564);
            this.uxChat.TabIndex = 2;
            // 
            // uxContactList
            // 
            this.uxContactList.Enabled = false;
            this.uxContactList.FormattingEnabled = true;
            this.uxContactList.ItemHeight = 20;
            this.uxContactList.Location = new System.Drawing.Point(8, 45);
            this.uxContactList.Name = "uxContactList";
            this.uxContactList.Size = new System.Drawing.Size(196, 564);
            this.uxContactList.TabIndex = 3;
            // 
            // uxChatScrollBar
            // 
            this.uxChatScrollBar.Enabled = false;
            this.uxChatScrollBar.Location = new System.Drawing.Point(762, 45);
            this.uxChatScrollBar.Name = "uxChatScrollBar";
            this.uxChatScrollBar.Size = new System.Drawing.Size(26, 564);
            this.uxChatScrollBar.TabIndex = 4;
            // 
            // uxContactScroll
            // 
            this.uxContactScroll.Enabled = false;
            this.uxContactScroll.Location = new System.Drawing.Point(178, 45);
            this.uxContactScroll.Name = "uxContactScroll";
            this.uxContactScroll.Size = new System.Drawing.Size(26, 564);
            this.uxContactScroll.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.contactOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // contactOptionsToolStripMenuItem
            // 
            this.contactOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAContactToolStripMenuItem,
            this.deleteAContactToolStripMenuItem});
            this.contactOptionsToolStripMenuItem.Name = "contactOptionsToolStripMenuItem";
            this.contactOptionsToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.contactOptionsToolStripMenuItem.Text = "Contacts";
            // 
            // addAContactToolStripMenuItem
            // 
            this.addAContactToolStripMenuItem.Name = "addAContactToolStripMenuItem";
            this.addAContactToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.addAContactToolStripMenuItem.Text = "Add a Contact";
            // 
            // deleteAContactToolStripMenuItem
            // 
            this.deleteAContactToolStripMenuItem.Name = "deleteAContactToolStripMenuItem";
            this.deleteAContactToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.deleteAContactToolStripMenuItem.Text = "Delete a contact";
            // 
            // InputOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 738);
            this.Controls.Add(this.uxContactScroll);
            this.Controls.Add(this.uxChatScrollBar);
            this.Controls.Add(this.uxContactList);
            this.Controls.Add(this.uxChat);
            this.Controls.Add(this.uxSendButton);
            this.Controls.Add(this.uxTextbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InputOutputForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InputOutputForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox uxTextbox;
        private System.Windows.Forms.Button uxSendButton;
        private System.Windows.Forms.ListBox uxChat;
        private System.Windows.Forms.ListBox uxContactList;
        private System.Windows.Forms.VScrollBar uxChatScrollBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAContactToolStripMenuItem;
        private System.Windows.Forms.VScrollBar uxContactScroll;
    }
}

