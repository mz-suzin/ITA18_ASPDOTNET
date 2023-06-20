namespace LaboratorioRestApi.Models;

public class Autor
{
    public int Id { get; set; }
    public string PrimeiroNome { get; set; } = null!;
    public string UltimoNome { get; set; } = null!;

    // RELACIONAMENTOS
    // 1 Autor pode ter 0 ou muitos livros
    // 1 livro pode ter 0 ou muitos autores
    // relacionamento N-N com livros -> precisa de uma tabela associativa: Autores_livros

    // autores - autores_livros
    // relacionamento 1-N
    // public List<Autor_Livro> Autores_Livros { get; set; } = null!;
    public List<Livro> Livros { get; set; } = null!;
}