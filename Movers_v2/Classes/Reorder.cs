using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    class Reorder
    {
        int reorderID, stockID;
        string status, discrepancies;
        DateTime order_date;
        decimal quantityordered, totalPrice;

        public Reorder(int reorderID, int stockID, DateTime date, decimal qty,  string status, string d, decimal tp)
        {
            this.reorderID = reorderID;
            this.stockID = stockID;
            this.order_date = date;
            this.quantityordered = qty;
            this.status = status;
            this.discrepancies = d;
            this.totalPrice = tp;
            
        }

        public Reorder()
        {
            reorderID = 0;
            stockID = 0;
            order_date = DateTime.MinValue;
            quantityordered = 0;
            status = "Not Delivered";
            discrepancies = "N/A";
            totalPrice = 0;

        }

        public int StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        public int ReorderID
        {
            get { return reorderID; }
            set { reorderID = value; }
        }

        public DateTime Order_Date
        {
            get { return order_date; }
            set { order_date = value; }
        }


        public decimal Quantityordered
        {
            get { return quantityordered; }
            set { quantityordered = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Discrepancies
        {
            get { return discrepancies; }
            set { discrepancies = value; }
        }


    }
}
