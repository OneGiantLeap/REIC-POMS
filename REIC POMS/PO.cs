using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class PO
    {
        public PO(string poNo,
                  string orderDate,
                  string deliveryDate,
                  string orderDescription,
                  string pqNo,
                  string paymentTerms,
                  string deliveryTerms,
                  double netSubtotal,
                  double deliveryCost,
                  double orderTotal,
                  int supplierID,
                  int customerID,
                  string soNo
                  )
        {
            PONo = poNo;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            OrderDescription = orderDescription;
            PQNo = pqNo;
            PaymentTerms = paymentTerms;
            DeliveryTerms = deliveryTerms;
            NetSubtotal = netSubtotal;
            DeliveryCost = deliveryCost;
            OrderTotal = orderTotal;
            SupplierID = supplierID;
            CustomerID = customerID;
            SONo = soNo;
         
        }

        public string PONo { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderDescription { get; set; }
        public string PQNo { get; set; }
        public string PaymentTerms { get; set; }
        public string DeliveryTerms { get; set; }
        public double NetSubtotal { get; set; }
        public double DeliveryCost { get; set; }
        public double OrderTotal{ get; set; }
        public int SupplierID { get; set; }
        public int CustomerID { get; set; }
        public string SONo { get; set; }

    }
}

