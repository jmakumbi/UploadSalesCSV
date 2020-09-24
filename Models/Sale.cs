using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadSales.Models
{
    public class Sale
    {
        public Guid Id { get; set; }
        public string ItemType { get; set; }
        public string OrderPriority { get; set; }
        public DateTime  OrderDate { get; set; }
        public double UnitPrice { get; set; }
        public double UnitsSold { get; set; }
        public double TotalCost { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalProfit { get; set; }

    }
}
