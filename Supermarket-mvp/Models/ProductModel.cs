using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Supermarket_mvp.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}

