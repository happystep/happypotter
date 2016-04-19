using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websocket_Chat_Client
{
    class Account
    {
        //public field for knowing if the current account is online or nots
        public bool IsOnline;

        //private field storing the username for the current accounts
        private string Username;
    
        /// <summary>
        /// Gets the username for the current account
        /// </summary>
        public string GetUsername
        {
            get { return Username; }
        }


    }
}
