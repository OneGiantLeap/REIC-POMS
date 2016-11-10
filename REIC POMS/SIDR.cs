using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace REIC_POMS
{
    class SIDR
    {
        public SIDR (int soNo,
                     int customerID,
                     string soDate,
                     string deliveryTerms,
                     string customerPONo,
                     int siNo,
                     int drNo,
                     double totalSales,
                     double vatSales,
                     double percentVAT,
                     double invoiceTotal
                    )
        {
            SONo = soNo;
            CustomerID = customerID;
            SODate = soDate;
            DeliveryTerms = deliveryTerms;
            CustomerPONo = customerPONo;
            SINo = siNo;
            DRNo = drNo;
            TotalSales = totalSales;
            VATSales = vatSales;
            PercentVAT = percentVAT;
            InvoiceTotal = invoiceTotal;
        }

        public int SONo { get; set; }
        public int CustomerID { get; set; }
        public string SODate { get; set; }
        public string DeliveryTerms { get; set; }
        public string CustomerPONo { get; set; }
        public int SINo { get; set; }
        public int DRNo { get; set; }
        public double TotalSales { get; set; }
        public double VATSales { get; set; }
        public double PercentVAT { get; set; }
        public double InvoiceTotal { get; set; }
    }
}
