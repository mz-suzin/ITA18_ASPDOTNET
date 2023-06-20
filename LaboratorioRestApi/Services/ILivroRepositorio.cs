using LaboratorioRestApi.Models;

namespace LaboratorioRestApi.Services;

public interface ILivroRepositorio
{
    Task<Livro> AdicionarAsync(Livro livro);
    Task<IEnumerable<Livro>> ConsultarTodosAsync(Livro livro);
    Task<IEnumerable<Livro?>> ConsultarLivroDeAutorPorIdAsync(int Id);
}