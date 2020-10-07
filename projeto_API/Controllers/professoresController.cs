using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_API.Data;
using projeto_API.Models;

namespace projeto_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class professoresController : Controller
  {
    public IRepository _repo { get; }
    public professoresController(IRepository repository)
    {
      _repo = repository;

    }


    [HttpGet]
    public IActionResult get()
    {
      try
      {
        return Ok();
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao conectar com o Servidor");
      }
    }


    [HttpGet("{idProfessor}")]
    public IActionResult get(int idProfessor)
    {
      try
      {
        return Ok();
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao conectar com o Servidor");
      }
    }


    [HttpPost]
    public async Task<IActionResult> post(Professor model)
    {
      try
      {
        _repo.Add(model);
        
        if(await _repo.SaveChangesAsync())
        {
            return Created($"/api/professor/{model.Id}", model);
        }
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao conectar com o Servidor");
      }
      return BadRequest();
    }


    [HttpPut("{idProfessor}")]
    public IActionResult put(int idProfessor)
    {
      try
      {
        return Ok();
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao conectar com o Servidor");
      }
    }


    [HttpDelete("{idProfessor}")]
    public IActionResult delete(int idProfessor)
    {
      try
      {
        return Ok();
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao conectar com o Servidor");
      }
    }

  }
}