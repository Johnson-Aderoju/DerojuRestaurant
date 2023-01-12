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
        public int ProductId {get; set;}
       
       [Required(ErrorMessage = "Name field is required.")]
       [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Name {get; set;}
        [Range(1,1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }       
        public string ImageUrl { get; set; } 
    }
}