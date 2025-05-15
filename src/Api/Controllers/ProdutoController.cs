
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase 
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    } 
}
