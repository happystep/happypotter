using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websocket_Chat_Client
{
    class Chat
    {
        //field that stores the ID of the current chats
        private int ID;
        
        //list that contains the current users of the chats
        private List<Account> users;
        
        /// <summary>
        /// Gets the current ID from the chat
        /// </summary>
        public int GetID
        {
            get { return ID; }
        }

        /// <summary>
        /// Gets the current list of users from the current chat
        /// </summary>
        public List<Account> GetUsers
        {
            get { return users; }
        }


    }
}
