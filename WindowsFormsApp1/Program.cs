using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = MSSqlConnectionProvider.GetConnectionString("Perniptop", "CRUDAppServer");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);

            bool loggedIn = false;
            while (!loggedIn)
            {
                using (var login = new LoginForm())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        loggedIn = true;
                    }
                    else
                    {
                        return; 
                    }
                }
            }

            Application.Run(new App());

        }
    }
}
