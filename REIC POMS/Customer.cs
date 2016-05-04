using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class Customer
    {
        //CONSTRUCTOR
        public Customer(int customerID,
                        string businessName,
                        string tinNumber,
                        string customerName,
                        string customerPerson,
                        string customerNumber,
                        string accountNumber,
                        string customerEmail,
                        string customerAddress)
        {
            CustomerID = customerID;
            BusinessName = businessName;
            TinNumber = tinNumber;
            CustomerName = customerName;
            CustomerPerson = customerPerson;
            CustomerNumber = customerNumber;
            AccountNumber = accountNumber;
            CustomerEmail = customerEmail;
            CustomerAddress = customerAddress;
        }

        //PROPERTIES
        public int CustomerID { get; set; }
        public string BusinessName { get; set; }
        public string TinNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPerson { get; set; }
        public string CustomerNumber { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }

    }
}
