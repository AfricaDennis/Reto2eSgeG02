﻿using System;
using System.Collections.Generic;

namespace Reto2eSgeG02.Core.Entities.DbViews
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
