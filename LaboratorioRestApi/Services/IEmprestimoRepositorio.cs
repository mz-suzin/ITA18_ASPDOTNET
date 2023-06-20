using LaboratorioRestApi.Models;

namespace LaboratorioRestApi.Services;

public interface IEmprestimoRepositorio
{
    Task<Emprestimo> AdicionarAsync(Emprestimo emprestimo);
    Task<Emprestimo> AlterarAsync(Emprestimo emprestimo);
    Task<Emprestimo?> ConsultarEmprestimoPorIdAsync(int Id);
}