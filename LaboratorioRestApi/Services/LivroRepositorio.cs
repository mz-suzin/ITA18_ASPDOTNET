using LaboratorioRestApi.Models;

namespace LaboratorioRestApi.Services;

public class LivroRepositorio : ILivroRepositorio
{
    public async Task<Livro> AdicionarAsync(Livro livro)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Livro?>> ConsultarLivroDeAutorPorIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Livro>> ConsultarTodosAsync(Livro livro)
    {
        throw new NotImplementedException();
    }
}