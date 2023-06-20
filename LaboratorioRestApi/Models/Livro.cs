namespace LaboratorioRestApi.Models;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; } = null!;

    // RELACIONAMENTO
    // 1 Autor pode ter 0 ou muitos livros
    // 1 livro pode ter 0 ou muitos autores
    // relacionamento N-N com livros -> precisa de uma tabela associativa: Autores_livros
    // ------
    // 1 Livro pode ter somente 1 emprestimo
    // 1 emprestimo pode ter diversos livros
    // relacionamento 1-N com emprestimos

    // LIVROS - AUTORES_LIVROS -> N-1
    // public List<Autor_Livro> Autores_Livros { get; set; } = null!;
    public ICollection<Autor> Autores { get; set; } = null!;

    // LIVROS - EMPRESTIMOS -> 1-N

    public List<Emprestimo> Emprestimos { get; set; } = null!;
    public int EmprestimoId { get; set; }

    
}