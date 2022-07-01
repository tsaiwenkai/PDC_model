﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PDC_model.Models
{
    public partial class Package
    {
        public Package()
        {
            Coffees = new HashSet<Coffee>();
        }

        public int PackageId { get; set; }
        public string PackageName { get; set; }

        public virtual ICollection<Coffee> Coffees { get; set; }
    }
}
