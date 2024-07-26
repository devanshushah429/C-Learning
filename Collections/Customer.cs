using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Customer
    {
        public int customerID;
        public String name;
        public DateTime joiningDate;
        public Customer(int customerID, String name, DateTime joiningDate)
        {
            this.customerID = customerID;
            this.name = name;
            this.joiningDate = joiningDate;
        }

        public String getName()
        {
            return this.name;
        }

    }
    class NewlyAddedCustomer : Customer
    {
        public int newlyID;
        public NewlyAddedCustomer(int customerID,String name, DateTime joiningDate, int newlyID): base(customerID,name,joiningDate)
        {
            this.newlyID = newlyID;
        }

        public int GetNewlyID()
        {
            return newlyID;
        }
    }
}
