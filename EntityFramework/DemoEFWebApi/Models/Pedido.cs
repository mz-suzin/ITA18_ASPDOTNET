namespace DemoEFWebApi.Models;

public class Pedido
{
    public int Id { get; set; } //vide produto.cs
    public DateTime DataEmissao { get; set; }


    //modelagem do relacionamento

    //CLIENTE
    // relacionamento N-1 com Cliente (vide cliente.cs)
    public Cliente Cliente { get; set; } = null!; //todo pedido deve ter um cliente associado a ele.
    
    //como cada pedido só pode ter um cliente, a chave estrangeira só pode estar aqui (pois deve ser unica)
    public int ClienteId { get; set; } //chave estrangeira aqui.


    // PRODUTO
    // Um produto pode ter zero ou muitos pedidos
    // Um pedido pode ter 0 (não iniciado) ou muitos produtos
    //Temos então um relacionamento N-N com Produto

    public ICollection<Produto> Produtos { get; set; } = null!;

    // precisa de tabela associativa
    // Item
    public List<Item> Itens { get; set; } = null!;

}