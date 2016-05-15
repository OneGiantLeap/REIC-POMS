using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REIC_POMS
{
    class Item
    {
        //text[#] refers to the number in the Filestream
        public Item(string partNumber,
                    string itemName,
                    string itemDescription,
                    double supplierUnitPrice,
                    double markup,
                    double reicUnitPrice,
                    int moq,
                    string uom,
                    string fromDate,
                    string toDate,
                    int supplierID
                    /*string supplierName, //text[10]
                    string supplierPerson,
                    string supplierNumber,
                    string supplierEmail,
                    string supplierAddress */
                    )

        {
            this.PartNumber = partNumber;
            this.ItemName = itemName;
            this.ItemDescription = itemDescription;
            this.SupplierUnitPrice = supplierUnitPrice;
            this.Markup = markup;
            this.ReicUnitPrice = reicUnitPrice;//cannot be assigned since it is ReadOnly
            this.Moq = moq;
            this.Uom = uom;
            this.FromDateNoTime = fromDate.ToString();
            this.ToDateNoTime = toDate.ToString();
            this.SupplierID = supplierID;
            /*this.SupplierName = supplierName;
            this.SupplierPerson = supplierPerson;
            this.SupplierNumber = supplierNumber;
            this.SupplierEmail = supplierEmail;
            this.SupplierAddress = supplierAddress;*/
        }

        public double ComputedValue { get { return (SupplierUnitPrice * Markup / 100); } }//to compute for the value added (markup)
        public string PartNumber { get; set; }
        public string ItemName { get; set; }
        public double SupplierUnitPrice { get; set; }
        public double Markup { get; set; }
        //public double ReicUnitPrice{ get { return (SupplierUnitPrice + ComputedValue); } }//to compute for the reic unit price
        public double ReicUnitPrice { get; set; }
        public int Moq { get; set; }
        public string Uom { get; set; }
        public string FromDateNoTime { get; set; }
        public string ToDateNoTime { get; set; }
        public string ItemDescription { get; set; }
        public int SupplierID { get; set; }
        /*public string SupplierName { get; set; }
        public string SupplierPerson { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; } */

    }
}
