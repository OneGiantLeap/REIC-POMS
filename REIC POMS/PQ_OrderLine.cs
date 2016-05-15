using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class PQ_OrderLine
    {
        
        public PQ_OrderLine(string pqNo,
                             string partNumber,
                             double reicUnitPrice,
                             int quantity,
                             double itemTotal)
        {
            PQNo = pqNo;
            PartNumber = partNumber;
            Quantity = quantity;
            ReicUnitPrice = reicUnitPrice;
            ItemTotal = itemTotal;
        }

       
        public string PQNo { get; set; }
        public string PartNumber { get; set; }
        public double ReicUnitPrice { get; set; }
        public int Quantity { get; set; }
        public double ItemTotal { get; set; }
        
    }
}
