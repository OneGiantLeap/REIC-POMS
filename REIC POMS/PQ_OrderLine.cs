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
                             int quantity)
        {
            PQNo = pqNo;
            PartNumber = partNumber;
            Quantity = quantity;
        }

       
        public string PQNo { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
    }
}
