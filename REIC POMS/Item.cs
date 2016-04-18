using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class Item
    {
              
        public Item (string partNumber,
                    string itemName,
                    double supplierUnitPrice,
                    double markup,
                    double reicUnitPrice,
                    int moq,
                    string uom,
                    string fromDate,
                    string toDate,
                    string itemDescription,
                    string supplierName,
                    string supplierPerson,
                    string supplierNumber, 
                    string supplierEmail,
                    string supplierAddress
                    )
            
        {
            this.PartNumber = partNumber;
            this.ItemName = itemName;
            this.SupplierUnitPrice = supplierUnitPrice;
            this.Markup = markup;
            //this.ReicUnitPrice = reicUnitPrice;//cannot be assigned since it is ReadOnly
            this.Moq = moq;
            this.Uom = uom;
            this.FromDateNoTime = fromDate.ToString();
            this.ToDateNoTime = toDate.ToString();
            this.ItemDescription = itemDescription;
            this.SupplierName = supplierName;
            this.SupplierPerson = supplierPerson;
            this.SupplierNumber = supplierNumber;
            this.SupplierEmail = supplierEmail;
            this.SupplierAddress = supplierAddress;
          
        }

        
        public double ComputedValue { get { return (SupplierUnitPrice * Markup / 100); } }//to compute for the value added (markup)
        public string PartNumber { get; set; }
        public string ItemName { get; set; }
        public double SupplierUnitPrice { get; set; }
        public double Markup { get; set; }
        public double ReicUnitPrice { get { return (SupplierUnitPrice + ComputedValue); } }//to compute for the reic unit price
        public int Moq { get; set; }
        public string Uom { get; set; }
        public string FromDateNoTime { get; set; }
        public string ToDateNoTime { get; set; }
        public string ItemDescription { get; set; }
        //public string SupplierDetails { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPerson { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }

    }
}
