using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerojuRez.Services.ProductAPI.Model.Dtos
{
    public class ProductDto
    {
        public int productId {get; set;}
        public string name {get; set;}
        public double price { get; set; }
        public string description { get; set; }
        public string categoryName { get; set; }       
        public string imageUrl { get; set; } 
    }
}