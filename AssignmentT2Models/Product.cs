using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentT2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Services { get; set; }
        public string Description{ get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1 to services")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 3 to 4 services")]
        [Range(1, 1000)]
        public double Price3 { get; set; }

        [Required]
        [Display(Name = "Price for 5 and above services")]
        [Range(1, 1000)]
        public double Price5 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
