using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_142_Challenge2_InheritPolyphormism.Entities
{
    internal class ImportedProduct : Product
    {

        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + $"Customs fee: {CustomsFee:F2}";
        }
    }
}
