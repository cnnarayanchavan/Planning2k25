using AsyncAwaitExample.Web.Model;
using Microsoft.AspNetCore.Mvc;

namespace AsyncAwaitExample.Web.Repo
{
    //Interface for segregate methods form their implimentations 
    public interface IProductRepo
    {
        //mthod 1 to get all products 
        Task<IEnumerable<Product>> GetAllAsync();

        //2nd method for get specific product by ID
        Task<ActionResult<Product>> GetByIdAsync(int id);

        //3rd method for adding product to list
        Task AddAsync(Product product);

        //4th method for adding product to List
        Task UpdateAsync(Product product);

        //5th pmethod for deleting product from list
        Task DeleteAsync(int id);
    }
}
