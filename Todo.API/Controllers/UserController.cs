using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Entities;

namespace Todo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
       public async Task<IActionResult> Get()
        {
            var user = new User();
            return Ok(user);
        }
    }
}
