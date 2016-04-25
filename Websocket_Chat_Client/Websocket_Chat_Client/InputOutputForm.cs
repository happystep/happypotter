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
            uxSendButton.Click += api.SendMessageToChat("hi", 0);
            uxLoginStrip.Click += api.LogIn(" ", " ");
           
        }

        private void InputOutputForm_Load(object sender, EventArgs e)
        {

        }

        private void uxSendButton_Click(object sender, EventArgs e)
        {
            api.SendMessageToChat(uxTextbox.Text, 0);
        }

    }
}
