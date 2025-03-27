using AsyncAwaitExample.Web.Model;
using AsyncAwaitExample.Web.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsyncAwaitExample.Web.Controller
{
    [Route("api/[controller]")] 
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repo;
        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _repo.GetAllAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            var product = await _repo.GetByIdAsync(id);

            if (product == null) return NotFound();

            return product;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            await _repo.AddAsync(product);
            return CreatedAtAction(nameof(Get), new { id = product.ProductId }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Product product)
        {
            if (id != product.ProductId) return BadRequest();
            await _repo.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}
