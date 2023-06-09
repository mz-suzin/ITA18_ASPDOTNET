namespace DemoEFWebApi.Models;

public class Produto
{
    public int Id { get; set; } //automaticamente corresponde a uma chave primaria autogerada - mesma coisa se fosse chamado IdProduto
    public string Nome { get; set; } = null!; //por default, ele vai configurar como nvarchar(max). Não quero. Como mudar? olhar LojinhaContext.cs e o modelBuilder
    public string? Descricao { get; set; }
    public int PrecoUnitario { get; set; } //definimos como int pra nao precisar se preocupar com conversao de centavos. Basta dividir por 100

    //modelagem do relacionamento

    // PEDIDO
    // Um produto pode ter zero ou muitos pedidos
    // Um pedido pode ter 0 (não iniciado) ou muitos produtos
    //Temos então um relacionamento N-N com Pedido

    public ICollection<Pedido> Pedidos { get; set; } = null!;

    // precisa de tabela associativa
    // ITEM
    public List<Item> Itens { get; set; } = null!;
}