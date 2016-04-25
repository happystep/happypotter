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
            this.uxTextbox.Location = new System.Drawing.Point(5, 404);
            this.uxTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxTextbox.Name = "uxTextbox";
            this.uxTextbox.Size = new System.Drawing.Size(440, 64);
            this.uxTextbox.TabIndex = 0;
            this.uxTextbox.Text = "";
            // 
            // uxSendButton
            // 
            this.uxSendButton.Enabled = false;
            this.uxSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.uxSendButton.Location = new System.Drawing.Point(448, 404);
            this.uxSendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSendButton.Name = "uxSendButton";
            this.uxSendButton.Size = new System.Drawing.Size(78, 62);
            this.uxSendButton.TabIndex = 1;
            this.uxSendButton.Text = "Send";
            this.uxSendButton.UseVisualStyleBackColor = true;
            this.uxSendButton.Click += new System.EventHandler(this.uxSendButton_Click);
            // 
            // uxChat
            // 
            this.uxChat.Enabled = false;
            this.uxChat.FormattingEnabled = true;
            this.uxChat.Location = new System.Drawing.Point(140, 29);
            this.uxChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxChat.Name = "uxChat";
            this.uxChat.Size = new System.Drawing.Size(387, 368);
            this.uxChat.TabIndex = 2;
            // 
            // uxContactList
            // 
            this.uxContactList.Enabled = false;
            this.uxContactList.FormattingEnabled = true;
            this.uxContactList.Location = new System.Drawing.Point(5, 29);
            this.uxContactList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxContactList.Name = "uxContactList";
            this.uxContactList.Size = new System.Drawing.Size(132, 368);
            this.uxContactList.TabIndex = 3;
            // 
            // uxChatScrollBar
            // 
            this.uxChatScrollBar.Enabled = false;
            this.uxChatScrollBar.Location = new System.Drawing.Point(508, 29);
            this.uxChatScrollBar.Name = "uxChatScrollBar";
            this.uxChatScrollBar.Size = new System.Drawing.Size(26, 367);
            this.uxChatScrollBar.TabIndex = 4;
            // 
            // uxContactScroll
            // 
            this.uxContactScroll.Enabled = false;
            this.uxContactScroll.Location = new System.Drawing.Point(119, 29);
            this.uxContactScroll.Name = "uxContactScroll";
            this.uxContactScroll.Size = new System.Drawing.Size(26, 367);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // contactOptionsToolStripMenuItem
            // 
            this.contactOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAContactToolStripMenuItem,
            this.deleteAContactToolStripMenuItem});
            this.contactOptionsToolStripMenuItem.Name = "contactOptionsToolStripMenuItem";
            this.contactOptionsToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.contactOptionsToolStripMenuItem.Text = "Contacts";
            // 
            // addAContactToolStripMenuItem
            // 
            this.addAContactToolStripMenuItem.Name = "addAContactToolStripMenuItem";
            this.addAContactToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addAContactToolStripMenuItem.Text = "Add a Contact";
            // 
            // deleteAContactToolStripMenuItem
            // 
            this.deleteAContactToolStripMenuItem.Name = "deleteAContactToolStripMenuItem";
            this.deleteAContactToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.deleteAContactToolStripMenuItem.Text = "Delete a contact";
            // 
            // InputOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 480);
            this.Controls.Add(this.uxContactScroll);
            this.Controls.Add(this.uxChatScrollBar);
            this.Controls.Add(this.uxContactList);
            this.Controls.Add(this.uxChat);
            this.Controls.Add(this.uxSendButton);
            this.Controls.Add(this.uxTextbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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

