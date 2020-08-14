using MSS.DB;
using MSS.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MSS
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
            DO.Configuraion config = new DB.Configuration().GET();
            if (config.MyId == null || config.MyId == "")
                Application.Run(new Register());
            else if (config.Code == null || config.Code == "")
                Application.Run(new AddValidCode());
            else
            {
               List<DO.User> users = new DB.User().ALL();
                if (users != null && users.Count > 0)
                    Application.Run(new Login());
                else Application.Run(new AddUser());
            }
        }
    }
}
