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
        [STAThread]
        static void Main()
        {
            SQLitePCL.Batteries_V2.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isMyPC = Environment.MachineName.Equals("Perniptop", StringComparison.OrdinalIgnoreCase);

            //isMyPC = false;
            if (isMyPC)
            {
                // Setup with SSMS using localhost
                string connectionString = MSSqlConnectionProvider.GetConnectionString("Perniptop", "CRUDAppServer");
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            }
            else
            {
                // Automatic setup using SQLite
                string conn = SQLiteConnectionProvider.GetConnectionString("defaultDatabase.db");
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema);

            }
            XpoDefault.Session = null;

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
