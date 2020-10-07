using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_API.Data;
using projeto_API.Models;

namespace projeto_API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class alunosController : Controller
  {
    public IRepository _repo { get; }
    public alunosController(IRepository repository)
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

    [HttpGet("{id}")]
    public IActionResult get(int id)
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
    public async Task<IActionResult> post(Aluno model)
    {
      try
      {
        _repo.Add(model);

        if(await _repo.SaveChangesAsync())
        {
            return Created($"/api/aluno/{model.Id}", model);
        }
      }
      catch (System.Exception)
      {
        return this.StatusCode(StatusCodes.Status500InternalServerError, "Erro ao conectar com o Servidor");
      }
      return BadRequest();
    }

    [HttpPut("{id}")]
    public IActionResult put(int id)
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

    [HttpDelete("{id}")]
    public IActionResult delete(int id)
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