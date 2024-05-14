using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab13.Models
{
    public class Product
    {
        //Primary Key
        public int ProductId { get; set; }

        //validation
        [MinLength(5)]
        [MaxLength(30)]
        public string ProductName { get; set; }

        //validation
        [Range(100,9999)]
        public double ProductPrice { get; set; }

        public string ProductImage { get; set; }

        //Foreign key
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}