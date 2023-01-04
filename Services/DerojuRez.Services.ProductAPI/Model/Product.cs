global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerojuRez.Models
{
    public class Product
    {
        [Key]
        public Guid productId {get; set;}
       
       [Required(ErrorMessage = "Name field is required.")]
       [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string name {get; set;}
        [Range(1,1000)]
        public double price { get; set; }
        public string description { get; set; }
        public string categoryName { get; set; }       
        public string imageUrl { get; set; } 
    }
}