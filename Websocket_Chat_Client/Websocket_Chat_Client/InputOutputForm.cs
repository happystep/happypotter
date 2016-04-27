using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientServerLibrary;

namespace Websocket_Chat_Client
{
    public partial class InputOutputForm : Form
    {
        
        IServerAPI api;
        Model m;
        

        public InputOutputForm(IServerAPI api)
        {
            InitializeComponent();
            this.api = api;
          //  uxSendButton.Click += api.SendMessageToChat("hi", 0);
          //  uxLoginStrip.Click += api.LogIn(" ", " ");
           
        }

        private void InputOutputForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// send button should send a mesages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSendButton_Click(object sender, EventArgs e)
        {
            api.SendMessageToChat(uxTextbox.Text, 0);
        }

        /// <summary>
        /// adding a contact event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.AddContact("");
        }

        /// <summary>
        /// deleting a contact ecent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteAContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.DeleteContact("");
        }

        /// <summary>
        /// logging out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            api.LogOut();
        }
        /// <summary>
        /// logging in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoginStrip_Click(object sender, EventArgs e)
        {
            api.LogOut();
        }
    }
}
