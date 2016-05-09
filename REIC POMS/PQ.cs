using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace REIC_POMS
{
    class PQ
    {
        public PQ(string pqNo,
                  string pqDate,
                  string rfqNo,
                  string pqFromDate,
                  string pqToDate,
                  string paymentTerms,
                  string deliveryTerms,
                  string billTo,
                  string shipTo,
                  string inFavorOf,
                  int customerID
                  )
        {
            PQNo = pqNo;
            PQDate = pqDate;
            RFQNo = rfqNo;
            PQFromDate = pqFromDate;
            PQToDate = pqToDate;
            PaymentTerms = paymentTerms;
            DeliveryTerms = deliveryTerms;
            BillTo = billTo;
            ShipTo = shipTo;
            InFavorOf = inFavorOf;
            CustomerID = customerID;
            /*CustomerName = customerName;
            CustomerPerson = customerPerson;
            CustomerNumber = customerNumber;
            CustomerEmail = customerEmail;
            CustomerAddress = customerAddress;
            PQItems = pqItems;*/
        }

        public string PQNo { get; set; }
        public string PQDate { get; set; }
        public string RFQNo { get; set; }
        public string PQFromDate { get; set; }
        public string PQToDate { get; set; }
        public string PaymentTerms { get; set; }
        public string DeliveryTerms { get; set; }
        public string BillTo { get; set; }
        public string ShipTo { get; set; }
        public string InFavorOf { get; set; }
        public int CustomerID { get; set; }
        /*  public string CustomerName { get; set; }
          public string CustomerPerson { get; set; }
          public string CustomerNumber { get; set; }
          public string CustomerEmail { get; set; }
          public string CustomerAddress { get; set; }
          public ArrayList PQItems { get; set; } */
    }
}
