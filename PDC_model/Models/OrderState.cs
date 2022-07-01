﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PDC_model.Models
{
    public partial class OrderState
    {
        public OrderState()
        {
            Orders = new HashSet<Order>();
        }

        public int OrderStateId { get; set; }
        public string OrderState1 { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
