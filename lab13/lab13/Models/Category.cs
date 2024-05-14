using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab13.Models
{
    public class Category
    {
        //Primary Key
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}