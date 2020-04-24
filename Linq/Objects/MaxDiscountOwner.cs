using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Objects
{
    public class MaxDiscountOwner
    {
        public string ShopName { get; set; }
        public Supplier Owner { get; set; }
        public double Discount { get; set; }
    }
}
