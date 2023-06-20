using LaboratorioRestApi.Models;

namespace LaboratorioRestApi.Services;

public interface IAutorRepositorio
{
    Task<Autor> AdicionarAsync(Autor autor);
    Task<Autor> AlterarAsync(Autor autor);
    Task<IEnumerable<Autor?>> ConsultarUltimoNomeAsync(string ultimoNome);
}