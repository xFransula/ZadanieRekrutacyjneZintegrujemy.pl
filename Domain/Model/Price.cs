using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Price : Entity
    {
        public string SKU { get; protected set; }
        public double PriceNetto { get; protected set; }
        public decimal DiscountedNettPrice { get; protected set; }
        public decimal VatRate { get; protected set; }
        public decimal DiscountedNettPricePerUnit { get; protected set; }

        public Price(
            string sKU, 
            double priceNetto, 
            decimal discountedNettPrice, 
            decimal vatRate, 
            decimal discountedNettPricePerUnit)
        {
            SKU = sKU;
            PriceNetto = priceNetto;
            DiscountedNettPrice = discountedNettPrice;
            VatRate = vatRate;
            DiscountedNettPricePerUnit = discountedNettPricePerUnit;
        }
    }
}
