using Microsoft.AspNetCore.Mvc;

namespace projeto_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class alunosController : Controller
    {
        public alunosController()
        {
            
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            return Ok();
        }

       [HttpPost] 
        public IActionResult post()
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult put(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            return Ok();
        }

    }
    


}