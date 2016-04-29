using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using ClientServerLibrary;
using Newtonsoft.Json;


namespace Websocket_Chat_Client
{
    class ChatController : IServerAPI
    {
        


        //attributes

        public event EventHandler update;

       


        //event MessageReceived (string packet); //not sure how to really od this 
        Model m;
        WebSocket ws;
        
        //operations
        
        /// <summary>
        /// This method adds a chat
        /// </summary>
        /// <param name="username">the username of the chat that will be added</param>
        /// <param name="ID">the ID of the chat that will be added</param>
        public void AddChat(string username, int ID)
        {
            string[] args = { "C_AddChat", DateTime.Now.ToString(), m.GetUsername, username, ID.ToString() };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }

        private void GotPacket(string packet)
        {
            bool didModelChange = false;

            string[] args = JsonConvert.DeserializeObject<string[]>(packet);
            //MessageBox.Show("Packet received is " + packet);
            if (args.Length < 3)
                return;

            if (args[0].Equals("S_BroadcastStatus"))
            {
                string username = args[3];
                bool isOnline = args[4].ToLower().Equals("true");
                Account account = m.GetAccount.Find(a => a.GetUsername.Equals(username));
                if (account != null)
                {
                    account.IsOnline = isOnline;
                }
            }
            else if (args[0].Equals("S_DeleteContact"))
            {

            }
            else if (args[0].Equals("S_SendChatID"))
            {

            }
            else if (args[0].Equals("S_SendContactList"))
            {

            }
            else if (args[0].Equals("S_Error"))
            {

            }
            else if (args[0].Equals("S_SendLoginReply"))
            {

            }
            else if (args[0].Equals("S_SendNewContact"))
            {

            }
            else if (args[0].Equals("S_SendUserStatus"))
            {

            }
            else if (args[0].Equals("S_SendMessage"))
            {

            }
            else
            {
                return;
            }

            if (didModelChange)
            { 
                //if model did change
                if (update != null)
                {
                    update(this, EventArgs.Empty);
                }
                //if changes are made-> update observers   
            }

           
        }

        /// <summary>
        /// This method add a contact
        /// </summary>
        /// <param name="contactName">the contact name that needs to be addded</param>
        public void AddContact(string contactName)
        {
            string[] args = { "C_AddContact", DateTime.Now.ToString(), m.GetUsername, contactName};
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageReceived"></param>
        public ChatController(Model m)//needs to implemented from API
        {
            ws = new WebSocket("ws://127.0.0.1:8005/chat");
            ws.OnMessage += (s, e) => GotPacket(e.Data);
            ws.Connect();
            this.m = m;

        }

        /// <summary>
        /// this method delets a contact
        /// </summary>
        /// <param name="contactName">the contact name that needs to be deleted</param>
        public void DeleteContact(string contactName)
        {
            string[] args = { "C_DeleteContact", DateTime.Now.ToString(), m.GetUsername, contactName };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);

        }
        /// <summary>
        /// this method takes care of the log in
        /// </summary>
        /// <param name="username">the username of the login</param>
        /// <param name="password">the password of the login</param>
        public void LogIn(string username, string password)
        {
            string[] args = { "C_LogIn", DateTime.Now.ToString(), " ", username, password };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);

        }

        /// <summary>
        /// This method takes care of the logout 
        /// </summary>
        public void LogOut()
        {
            string[] args = { "C_LogOut", DateTime.Now.ToString(), m.GetUsername };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }

        /// <summary>
        /// this methos opens the chat
        /// </summary>
        /// <param name="username">user name of the chat that needs to be opened</param>
        public void OpenChat(string username)
        {
            string[] args = { "C_OpenChat", DateTime.Now.ToString(), m.GetUsername, username };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }

        /// <summary>
        /// this method takes care of requesting a contact list
        /// </summary>
        public void RequestContactList()
        {
            string[] args = { "C_RequestContactList", DateTime.Now.ToString(), m.GetUsername};
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }
        
        /// <summary>
        /// this method requests the status of a contact
        /// </summary>
        /// <param name="username">the username of the contact that the status is being requested</param>
        public void RequestContactStatus(string username)
        {
            string[] args = { "C_RequestContactStatus", DateTime.Now.ToString(), m.GetUsername,username };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }

       

        public void SendMessageToChat(string message, int chatID)
        {
            string[] args = { "C_SendMessageToChat", DateTime.Now.ToString(), m.GetUsername, message, chatID.ToString() };
            string json = JsonConvert.SerializeObject(args);
            ws.Send(json);
        }
    }
}
