using System;
using System.Collections.Generic;

namespace Reto2eSgeG02.Core.Entities
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
