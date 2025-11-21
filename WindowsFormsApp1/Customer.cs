using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [OptimisticLocking(true)]
    public class Customer : XPLiteObject
    {
        public Customer(Session session) : base(session)
        {
            session.LockingOption = LockingOption.Optimistic;
        }

        int _code;
        [DevExpress.Xpo.Key]
        [Size(10)]
        public int Code
        {
            get { return _code; }
            set { SetPropertyValue(nameof(Code), ref _code, value); }
        }

        string _companyName;
        [Size(50)]
        public string CompanyName
        {
            get { return _companyName; }
            set { SetPropertyValue(nameof(CompanyName), ref _companyName, value); }
        }

        string _country;
        [Size(40)]
        public string Country
        {
            get { return _country; }
            set { SetPropertyValue(nameof(Country), ref _country, value); }
        }

        string _address;
        [Size(50)]
        public string Address
        {
            get { return _address; }
            set { SetPropertyValue(nameof(Address), ref _address, value); }
        }

        [Phone]
        string _contactNumber;
        [Size(12)]
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { SetPropertyValue(nameof(ContactNumber), ref _contactNumber, value); }
        }

        DateTime _lastOrderDate;
        public DateTime LastOrderDate
        {
            get { return _lastOrderDate; }
            set { SetPropertyValue(nameof(LastOrderDate), ref _lastOrderDate, value); }
        }
    }
}
