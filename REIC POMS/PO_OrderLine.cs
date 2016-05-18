using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class PO_OrderLine
    {
        public PO_OrderLine(string poNo,
                            string partNumber,
                            double supplierUnitPrice,
                            int quantity,
                            double itemTotal)
        {
            PONo = poNo;
            PartNumber = partNumber;
            Quantity = quantity;
            SupplierUnitPrice = supplierUnitPrice;
            ItemTotal = itemTotal;
        }


        public string PONo { get; set; }
        public string PartNumber { get; set; }
        public double SupplierUnitPrice { get; set; }
        public int Quantity { get; set; }
        public double ItemTotal { get; set; }

    }

}

