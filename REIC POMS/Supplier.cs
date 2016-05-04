using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class Supplier
    {
        public Supplier (
                    int supplierID,
                    string supplierName,
                    string supplierPerson,
                    string supplierNumber,
                    string supplierEmail,
                    string supplierAddress
                    )
        {
            this.SupplierID = supplierID;
            this.SupplierName = supplierName;
            this.SupplierPerson = supplierPerson;
            this.SupplierNumber = supplierNumber;
            this.SupplierEmail = supplierEmail;
            this.SupplierAddress = supplierAddress;
        }

        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPerson { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }
    }
}
