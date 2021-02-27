using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<Product> Products { get; private set; }
    }
}