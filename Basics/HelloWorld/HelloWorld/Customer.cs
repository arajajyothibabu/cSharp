using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Customer
    {

        int customerId;
        string name;
        DateTime dob;
        string phone;

        public Customer(int customerId, string name, DateTime dob, string phone)
        {
            this.customerId = customerId;
            this.name = name;
            this.dob = dob;
            this.phone = phone;
        }

        public int CustomerId
        {
            get
            {
                return this.customerId;
            }
            private set
            {
                this.customerId = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
        public double Age
        {
            get
            {
                return DateTime.Today.Subtract(this.dob).TotalDays;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            private set
            {
                this.phone = value;
            }
        }
    }
}
