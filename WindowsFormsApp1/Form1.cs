using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private XPCollection xpCollection;
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = MSSqlConnectionProvider.GetConnectionString("Perniptop", "CRUDAppServer");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            LoadData();
        }

        public void LoadData()
        {
            xpCollection = new XPCollection(typeof(Customer));
            gridControl1.DataSource = xpCollection;   
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
