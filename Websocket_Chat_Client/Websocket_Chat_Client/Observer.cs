using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websocket_Chat_Client
{
    public interface Observer
    {
        List<Observer> observers { get; set; }


        void Update();
       

    }
}
