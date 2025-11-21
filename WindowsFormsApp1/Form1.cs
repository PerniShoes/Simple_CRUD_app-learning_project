using DevExpress.Utils.MVVM;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
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
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }
        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var customer = gridView1.GetFocusedRow() as Customer;
            if (customer != null)
            {
                CodeField.EditValue = customer.Code;
                CompanyNameField.Text = customer.CompanyName;
                ContactNumberField.Text = customer.ContactNumber;
                CountryField.Text = customer.Country;
                AddressField.Text = customer.Address;
                LastOrderDateField.EditValue = customer.LastOrderDate;
            }

        }

        private XPCollection xpCollection;
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = MSSqlConnectionProvider.GetConnectionString("Perniptop", "CRUDAppServer");
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            LoadData();
            RefreshCountryChart();
        }

        public void LoadData()
        {
            xpCollection = new XPCollection(typeof(Customer));
            gridControl1.DataSource = xpCollection;   
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var promptWindow = XtraMessageBox.Show("<b><color=red>Delete</color></b> selected data?", "Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , DevExpress.Utils.DefaultBoolean.True);

            if(promptWindow == DialogResult.Yes)
            {
                using (var uow = new UnitOfWork())
                {
                    var selected = gridView1.GetSelectedRows().Select(
                        xpCollection => gridView1.GetRow(xpCollection) as Customer).ToList();


                    var customersToDelete = uow.Query<Customer>().AsEnumerable().Where(
                        customer => selected.Any(x => customer.Code == x.Code)).ToList();
                    uow.Delete(customersToDelete);
                    uow.CommitChanges();
                    xpCollection.Reload();

                }

            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var uow = new UnitOfWork())
            {
                var customer = new Customer(uow);

                int codeTemp = int.Parse(CodeField.EditValue.ToString());
                customer.Code = codeTemp;
                customer.CompanyName = CompanyNameField.Text;
                customer.ContactNumber = ContactNumberField.Text;
                customer.Country = CountryField.Text;
                customer.Address = AddressField.Text;
                if (LastOrderDateField.EditValue != null)
                {
                    customer.LastOrderDate = DateTime.Parse(LastOrderDateField.EditValue.ToString());
                }
                else
                {
                    customer.LastOrderDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                }
                    var exists = uow.Query<Customer>().Any(x => x.Code == codeTemp);

                if (exists)
                {
                    XtraMessageBox.Show($"There is already a customer with id: {customer.Code}", "Input error");
                    CodeField.Focus();
                    return;
                }

                uow.CommitChanges();
                xpCollection.Reload();
                XtraMessageBox.Show("Saved!", "Succes");
                RefreshCountryChart();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var chosenCustomerCode = int.Parse(CodeField.EditValue.ToString());

            var promptWindow = XtraMessageBox.Show($"<b><color=green>Update</color></b> customer data (based on code)?", "Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question
                , DevExpress.Utils.DefaultBoolean.True);

            if(promptWindow == DialogResult.Yes)
            {
                using (var uow = new UnitOfWork())
                {
                    var customer = uow.Query<Customer>().Where(x => x.Code == chosenCustomerCode).FirstOrDefault();
                    if(customer == null)
                    {
                        XtraMessageBox.Show("Customer not found! (check code)", "Error");
                        return;
                    }
                    customer.CompanyName = CompanyNameField.Text;
                    customer.ContactNumber = ContactNumberField.Text;
                    customer.Country = CountryField.Text;
                    customer.Address = AddressField.Text;
                    if (LastOrderDateField.EditValue != null)
                    {
                        customer.LastOrderDate = DateTime.Parse(LastOrderDateField.EditValue.ToString());
                    }
                    else
                    {
                        customer.LastOrderDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                    }


                    uow.CommitChanges();
                    xpCollection.Reload();
                    XtraMessageBox.Show("Updated!", "Succes");
                    RefreshCountryChart();
                }

            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CodeField.EditValue = "10000";
            CompanyNameField.Text = "";
            ContactNumberField.Text = "";
            CountryField.Text = "";
            AddressField.Text = "";
            LastOrderDateField.EditValue = "";
            CodeField.Focus();

        }

        private void CountryChart_Click(object sender, EventArgs e)
        {
            
        }

        private void RefreshCountryChart()
        {
            using (var uow = new UnitOfWork())
            {
                var allCustomers = uow.Query<Customer>().ToList();

                var countryCounts = allCustomers
                    .GroupBy(c => c.Country)
                    .Select(g => new { Country = g.Key, Count = g.Count() })
                    .ToList();

                CountryChart.Series.Clear();

                Series series = new Series("Companies by Country", ViewType.NestedDoughnut);

                foreach (var item in countryCounts)
                    series.Points.Add(new SeriesPoint(item.Country, item.Count));

                ((PieSeriesLabel)series.Label).TextPattern = "{A}";
                ((PieSeriesLabel)series.Label).TextColor = Color.Black;
               series.LegendTextPattern = "{VP:p0}";

                CountryChart.Series.Add(series);
            }
        }

        private void RefreshChartButton_Click(object sender, EventArgs e)
        {
            RefreshCountryChart();
        }
    }
}
