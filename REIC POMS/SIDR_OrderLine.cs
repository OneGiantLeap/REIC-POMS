using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class SIDR_OrderLine
    {
        public SIDR_OrderLine(int soNo,
                              string partNumber,
                              double reicUnitPrice,
                              int quantity,
                              double itemTotal)
        {
            SONo = soNo;
            PartNumber = partNumber;
            Quantity = quantity;
            ReicUnitPrice = reicUnitPrice;
            ItemTotal = itemTotal;
        }


        public int SONo { get; set; }
        public string PartNumber { get; set; }
        public double ReicUnitPrice { get; set; }
        public int Quantity { get; set; }
        public double ItemTotal { get; set; }

    }
}
