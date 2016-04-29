using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class RFQ_OrderLine
    {
        //CONSTRUCTOR
        public RFQ_OrderLine(string rfqNo,
                             string partNumber,
                             int quantity)
        {
            RFQNo = rfqNo;
            PartNumber = partNumber;
            Quantity = quantity;
        }

        //PROPERTIES
        public string RFQNo { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
    }
}
