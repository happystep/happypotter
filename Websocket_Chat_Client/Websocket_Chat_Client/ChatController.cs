using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websocket_Chat_Client
{
    class ChatController
    {
        //////this will not be completed yet... missing Websocket sharp, and explanations


        //attributes
        //message received?
        //websocket object

        //operations
        
        /// <summary>
        /// This method adds a chat
        /// </summary>
        /// <param name="username">the username of the chat that will be added</param>
        /// <param name="ID">the ID of the chat that will be added</param>
        public void AddChat(string username, int ID)
        {

        }

        /// <summary>
        /// This method add a contact
        /// </summary>
        /// <param name="contactName">the contact name that needs to be addded</param>
        public void AddContact(string contactName)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageReceived"></param>
        public void ChatController(message MessageReceived)//needs to implemented from API
        {


        }

        /// <summary>
        /// this method delets a contact
        /// </summary>
        /// <param name="contactName">the contact name that needs to be deleted</param>
        public void DeleteContact(string contactName)
        {

        }
        /// <summary>
        /// this method takes care of the log in
        /// </summary>
        /// <param name="username">the username of the login</param>
        /// <param name="password">the password of the login</param>
        public void LogIn(string username, string password)
        {

        }

        /// <summary>
        /// This method takes care of the logout 
        /// </summary>
        public void LogOut()
        {

        }

        /// <summary>
        /// this methos opens the chat
        /// </summary>
        /// <param name="username">user name of the chat that needs to be opened</param>
        public void OpenChat(string username)
        {

        }

        /// <summary>
        /// this method takes care of requesting a contact list
        /// </summary>
        public void RequestContactList()
        {

        }
        
        /// <summary>
        /// this method requests the status of a contact
        /// </summary>
        /// <param name="username">the username of the contact that the status is being requested</param>
        public void RequestContactStatus(string username)
        {

        }

        /// <summary>
        /// method that is goint to be in stand by waiting for the packets to come in
        /// </summary>
        /// <param name="e"></param>
        private void GotPacket(MessageEventArgs e)
        {
            
        }

    }
}
