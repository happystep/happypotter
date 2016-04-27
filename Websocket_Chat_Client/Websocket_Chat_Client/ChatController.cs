﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using ClientServerLibrary;

namespace Websocket_Chat_Client
{
    class ChatController : IServerAPI
    {
        //////this will not be completed yet... missing Websocket sharp, and explanations


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
            throw new NotImplementedException();
        }

        private void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            bool didModelChange = false;


            if (didModelChange)
            { 
                //if model did change
                if (update != null)
                {
                    update(this, EventArgs.Empty);
                }
                //if changes are made-> update observers   
            }

            throw new NotImplementedException();
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
        public ChatController(Model m)//needs to implemented from API
        {
            ws = new WebSocket(" "); 
            ws.OnMessage += Ws_OnMessage;
            this.m = m;

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

        public void SendMessageToChat(string message, int chatID)
        {
            throw new NotImplementedException();
        }
    }
}
