using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Websocket_Chat_Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model m = new Model();
            ChatController c = new ChatController(m);
            InputOutputForm f = new InputOutputForm(c);
            c.update += f.OnModelUpdate;

           //login message box

            Application.Run(f);
        }
    }
}
