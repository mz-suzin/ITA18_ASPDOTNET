namespace DemoEFWebApi.Models;

public class Item
{
    public int Quantidade { get; set; }


    //modelagem do relacionamento
    // TABELA ASSOCIATIVA - preicsa de duas chaves - de produto e de pedido

    //PRODUTO
    // 1 Item pode ter somente um produto
    // 1 Produto pode ter muitos itens
    // relacionamento N-1 com Produto

    public Produto Produto { get; set; } = null!;
    public int ProdutoId { get; set; } //chave esterangeira

    //PEDIDO
    // 1 Item pode ter 1 pedidos
    // 1 pedido pode muitos itens
    // relacionamento 1-N

    public Pedido Pedido { get; set; } = null!;
    public int PedidoId { get; set; }
}