namespace DemoEFWebApi.Models;

public class Cliente
{
    public int Id { get; set; } //vide produto.cs
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? Telefone { get; set; }

    //modelagem do relacionamento

    //PEDIDO
    // - 1 cliente pode ter varios pedidos
    // - 1 pedido pode ter um cliente
    // relacionamento 1-N com Pedido

    //vamos usar uma propriedade de navegação
    public List<Pedido> Pedidos { get; set; } = null!; //a lista pode estar vazia ou não - olhar agora pedido.cs


    

}