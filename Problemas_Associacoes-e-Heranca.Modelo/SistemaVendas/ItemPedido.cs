using System;

namespace Problemas_Associacoes_e_Heranca.Modelo.SistemaVendas;

public class ItemPedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal Subtotal => Produto.Preco * Quantidade;

    public ItemPedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }
}
