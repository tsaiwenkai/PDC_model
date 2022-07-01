using System;
using System.Collections.Generic;

#nullable disable

namespace PDC_model.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoriesName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
