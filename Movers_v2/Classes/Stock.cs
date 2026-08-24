using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    public class Stock
    {
        int stockID, threshold;
        string itemname, stockType;
        decimal price, quantity;

        public Stock(int StockID, string Itemname, decimal Quantity, int Threshold, decimal Price, string stockType)
        {
            this.stockID = StockID;
            this.itemname = Itemname;
            this.quantity = Quantity;
            this.threshold = Threshold;
            this.price = Price;
            this.stockType = stockType;
        }

        public Stock()
        {
            stockID = 0;
            quantity = 0;
            itemname = "";
            threshold = 0;
            price = 0;
            stockType = "";

        }

        public int StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        public string Itemname
        {
            get { return itemname; }
            set { itemname = value; }
        }


        public string StockType
        {
            get { return stockType; }
            set { stockType = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Threshold
        {
            get { return threshold; }
            set { threshold = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
