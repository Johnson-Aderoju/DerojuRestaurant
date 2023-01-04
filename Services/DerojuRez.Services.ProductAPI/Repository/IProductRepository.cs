using System;
using System.Collections.Generic;
using DerojuRez.Services.ProductAPI.Model.Dtos;
using System.Linq;
using System.Threading.Tasks;

namespace DerojuRez.Services.ProductAPI
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);

    }
}