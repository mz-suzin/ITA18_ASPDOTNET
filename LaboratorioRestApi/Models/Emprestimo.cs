namespace LaboratorioRestApi.Models;

public class Emprestimo
{
    public int Id { get; set; }
    public DateOnly dataRetirada { get; set; } 
    public DateOnly dataDevolucao { get; set; }
    public bool entregue { get; set; }

    // RELACIONAMENTOS
    // 1 Livro pode ter somente 1 emprestimo
    // 1 emprestimo pode ter diversos livros
    // relacionamento 1-N com emprestimos

    public Livro Livros { get; set; } = null!;
}