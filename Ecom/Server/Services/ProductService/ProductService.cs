﻿using Ecom.Server.Data;

namespace Ecom.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext dataContext) 
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await _dataContext.Products.FindAsync(productId);
            if(product == null)
            {
                response.Success = false;
                response.Message = "Sorry, This Product Does Not Exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductListAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await _dataContext.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _dataContext.Products
                    .Where(p => p.Category.Url.ToLower() == categoryUrl.ToLower())
                    .ToListAsync()
            };

            return response;
        }
    }
}
