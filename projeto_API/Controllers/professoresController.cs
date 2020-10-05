using Microsoft.AspNetCore.Mvc;

namespace projeto_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class professoresController: Controller
    {
        public professoresController()
        {
            
        }


        [HttpGet]
        public IActionResult get()
        {
            return Ok();
        }


        [HttpGet("{idProfessor}")]
        public IActionResult get(int idProfessor)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult post()
        {
            return Ok();
        }


        [HttpPut("{idProfessor}")]
        public IActionResult put(int idProfessor)
        {
            return Ok();
        }


        [HttpDelete("{idProfessor}")]
        public IActionResult delete(int idProfessor)
        {
            return Ok();
        }

    }
}