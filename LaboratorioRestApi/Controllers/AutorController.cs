using Microsoft.AspNetCore.Mvc;
using LaboratorioRestApi.Models;
using LaboratorioRestApi.Database;
using LaboratorioRestApi.Services;
using LaboratorioRestApi.DTO;

namespace LaboratorioRestApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class AutorController : ControllerBase
{
    private readonly IAutorRepositorio _autorRepositorio;

    public AutorController(IAutorRepositorio autorRepositorio)
    {
        _autorRepositorio = autorRepositorio;
    }

    //GET .../api/v1/Autor/{ultimoNome}
    [HttpGet("{ultimoNome}")]
    public async Task<IEnumerable<Autor?>> FindByAuthorLastName(string ultimoNome)
    {
        return await _autorRepositorio.ConsultarUltimoNomeAsync(ultimoNome);
    }

    [HttpPost]
    public async Task<ActionResult<AutorDTO>> AdicionarAsync(AutorDTO autorDto)
    {
        try
        {
            var autor = Adapters.toModel(autorDto);
            var autorCriado = await _autorRepositorio.AdicionarAsync(autor);
            
            return Created("Autor criado com sucesso", autorCriado);

        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }

    [HttpPatch]
    public async Task<ActionResult<AutorDTO>> AlterarAsync(AutorDTO autorDto)
    {
        try
        {
            var autor = Adapters.toModel(autorDto);
            var autorAtualizado = await _autorRepositorio.AlterarAsync(autor);

            return Created("Autor atualizado com sucesso", autorAtualizado);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}