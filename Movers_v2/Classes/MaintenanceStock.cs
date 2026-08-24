using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{
    internal class MaintenanceStock
    {

        int maintenancestockID, maintenanceID, stockID ;
        decimal totalCost, maintenanceStockQuantity;

        public MaintenanceStock(int msi, int mi, int si, decimal c, decimal msq)
        {
           maintenancestockID  = msi;
            maintenanceID = mi;
            stockID = si;
            totalCost = c;
            maintenanceStockQuantity = msq;
        }

        public MaintenanceStock()
        {
            maintenancestockID = 0;
            maintenanceID = 0;
            stockID = 0;
            totalCost = 0;
            maintenanceStockQuantity = 0;
        }

        public int MaintenancestockID
        {
            get { return maintenancestockID; }
            set {   maintenancestockID = value; }
        }
        public int MaintenanceID
        {
            get { return maintenanceID; }
            set { maintenanceID = value; }
        }

        public int StockID
        {
            get { return stockID; }
            set { stockID = value; }
        }

        public Decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public decimal MaintenanceStockQuantity
        {
            get { return maintenanceStockQuantity; }
            set { maintenanceStockQuantity = value; }
        }
    }
}
