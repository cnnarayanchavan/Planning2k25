using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_Swagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult CallUser()
        {
            return Ok("Hey Theer!! Web Api Core this side");
        }

        [HttpPost]
        public IActionResult CreateUser(string Name)
        {
            return Ok("Post method to add data");
        }

        [HttpPut]
        public IActionResult UpdateUser()
        {
            return Ok("Put method to update data");
        }

        [HttpDelete]
        public IActionResult DeleteUser() 
        {
            return Ok("Delete method to remove user data");
        }
    }
}
