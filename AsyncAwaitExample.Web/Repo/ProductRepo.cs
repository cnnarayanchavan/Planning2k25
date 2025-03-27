
using AsyncAwaitExample.Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace AsyncAwaitExample.Web.Repo
{
    public class ProductRepo : IProductRepo
    {
        private readonly List<Product> _products;

        public ProductRepo()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, Name = "Laptop", Price = 75000 },
                new Product { ProductId = 2, Name = "Mobile", Price = 25000 }
            };
        }

        //st method with implimentation 
        public IEnumerable<Product> GetAllAsync() => _products;

        //2nd method with implimentation 
        public Product GetByIdAsync(int id) => _products.FirstOrDefault(p => p.ProductId == id);

        //3ed method with implimentation 
        public void AddAsync(Product product) => _products.Add(product);

        //4th method with implimentation 
        public void UpdateAsync(Product product)
        {
            var existingProduct = GetByIdAsync(product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
            }
        }

        //5th method with implimentation 
        public void DeleteAsync(int id) => _products.RemoveAll(p => p.ProductId == id);

    }
}