using System;
using System.Collections.Generic;

namespace Reto2eSgeG02.Core.Entities
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
