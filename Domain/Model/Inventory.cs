using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Inventory
    {
        public int Product_id { get; protected set; }
        public string SKU { get; protected set; }
        public string Unit { get; protected set; }
        public double Qty { get; protected set; }
        public string Manufacturer { get; protected set; }
        public string Shipping { get; protected set; }
        public decimal? Shipping_cost { get; protected set; }

        public Inventory(
            int product_id, 
            string sKU, 
            string unit, 
            double qty, 
            string manufacturer, 
            string shipping,
            decimal? shipping_cost)
        {
            Product_id = product_id;
            SKU = sKU;
            Unit = unit;
            Qty = qty;
            Manufacturer = manufacturer;
            Shipping = shipping;
            Shipping_cost = shipping_cost;
        }
    }
}

