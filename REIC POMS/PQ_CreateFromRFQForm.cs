using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace REIC_POMS
{
    public partial class PQ_CreateFromRFQForm : Form
    {
        private MySQLDatabaseDriver sql;
        private ArrayList pqList;
        private ArrayList rfqList;

        public PQ_CreateFromRFQForm()
        {
            InitializeComponent();
            sql = new MySQLDatabaseDriver();
            rfqList = new ArrayList(); 
            sql.SelectAllRFQ(rfqList);
        }

        public bool cancel;

        public bool Cancel
        {
            get { return cancel; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Search through all the RFQ nos, if RFQ no match with the given RFQ no, chichick!!!        
            
            for (int i = 0; i < rfqList.Count; i++)
            {
                RFQ rfq = (RFQ)rfqList[i]; //retrieve attribute values from this specific RFQ.
                if (rfq.RFQNo == txtRFQNumber.Text)
                {
                    //if the RFQno inputted, matches to any rfqnos, it would get the details of spec. rfq and put in the create form
                    PQ_CreateForm pf = new PQ_CreateForm(); //initialize the create form
                    RFQ r = sql.SelectRFQDetails(rfq.RFQNo); //use MYSQLDatabaseDriver to access SelectRFQDetails then use the RFQno inputted

                    string year = DateTime.Now.ToString("yy");
                    string month = DateTime.Now.ToString("MM");
                    int pqCount = sql.GetRowCount("pq_t", year, month);
                    string generatedPQNo = year + month + "-" + (pqCount + 1).ToString("D3"); 
                    pf.PQNo = generatedPQNo;

                    pf.RFQNo = r.RFQNo; //details are taken from ^
                    pf.PaymentTerms = r.PaymentTerms;
                    pf.DeliveryTerms = r.DeliveryTerms;

                    Customer c = sql.SelectCustomerDetails(r.CustomerID); //to retrieve the details of Customer from MySqlDatabaseDriver
                    pf.CustomerPerson = c.CustomerPerson;
                    pf.CustomerNumber = c.CustomerNumber;
                    pf.CustomerEmail = c.CustomerEmail;
                    pf.CustomerAddress = c.CustomerAddress;

                    pf.ShowDialog();
                                        
                    if (pf.Cancel == false)
                    {//if save button were clicked, this will save the pq details in arrayList then in the database
                        
                        pqList.Add(new PQ(pf.PQNo,
                                            pf.PQDate,
                                            pf.RFQNo,
                                            pf.FromDate,
                                            pf.ToDate,
                                            pf.PaymentTerms,
                                            pf.DeliveryTerms,
                                            pf.BillTo,
                                            pf.ShipTo,
                                            pf.InFavorOf,
                                            pf.CustomerIDFK));


                        PQ newPQ = (PQ)pqList[(pqList.Count - 1)];
                        sql.InsertPQ(newPQ);

                        for (int j = 0; j < pf.PQOrderLineList.Count; j++)
                        {
                            PQ_OrderLine pol = (PQ_OrderLine)pf.PQOrderLineList[i];

                            sql.InsertPQOrderLine(pol);

                            MessageBox.Show("OrderLine added to comprehensive list: " + pol.PQNo + ", " + pol.PartNumber + ", " + pol.Quantity);
                        }
                    }
            }

            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
        }
    }
}
