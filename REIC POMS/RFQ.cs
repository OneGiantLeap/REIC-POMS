using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class RFQ
    {
        //CONSTRUCTOR
        public RFQ(string rfqNo,
                   string requestDate, //In Data Dictionary, this is a DATE. What did Ken use in the Item class? HELP.
                   string paymentTerms,
                   string accountNumber,
                   string deliveryTerms,
                   string inFavorOf,
                   string customerName, //ENIGMA
                   string supplierName, //ENIGMA (plus its other fields)
                   string supplierPerson,
                   string supplierNumber,
                   string supplierEmail,
                   string supplierAddress)//,
                   //Item[] rfqItems) //NOT SURE IF IT'S RIGHT; please add Item class, lest this remains red    

        {
            RFQNo = rfqNo;
            RequestDate = requestDate;
            PaymentTerms = paymentTerms;
            AccountNumber = accountNumber;
            DeliveryTerms = deliveryTerms;
            InFavorOf = inFavorOf;
            CustomerName = customerName;
            SupplierName = supplierName;
            SupplierPerson = supplierPerson;
            SupplierNumber = supplierNumber;
            SupplierEmail = supplierEmail;
            SupplierAddress = supplierAddress;
            //RFQItems = rfqItems; //NOT SURE LOGIC BEHIND THIS IS RIGHT
        }

        //PROPERTIES
        public string RFQNo { get; set; }
        public string RequestDate { get; set; } //In Data Dictionary, this is a DATE.
        public string PaymentTerms { get; set; }
        public string AccountNumber { get; set; }
        public string DeliveryTerms { get; set; }
        public string InFavorOf { get; set; }
        public string CustomerName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPerson { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }
        //public Item[] RFQItems { get; set; } //NOT SURE IF IT'S RIGHT; Please add Item class, lest this remains red    
    }
}
