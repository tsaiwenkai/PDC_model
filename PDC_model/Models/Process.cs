using System;
using System.Collections.Generic;

#nullable disable

namespace PDC_model.Models
{
    public partial class Process
    {
        public Process()
        {
            Coffees = new HashSet<Coffee>();
        }

        public int ProcessId { get; set; }
        public string ProcessName { get; set; }

        public virtual ICollection<Coffee> Coffees { get; set; }
    }
}
