using System;
using System.Linq;

namespace Problemas_Associacoes_e_Heranca.Modelo.SistemaVendas;

public class Pedido
{
    private List<ItemPedido> itens = new();

    public IReadOnlyList<ItemPedido> Itens => itens.AsReadOnly();

    public decimal Total => itens.Sum(i => i.Subtotal);

    public void AdicionarItem(Produto produto, int quantidade)
    {
        var existente = itens.Find(i => i.Produto.Codigo == produto.Codigo);
        if (existente != null)
        {
            existente.Quantidade += quantidade;
        }
        else
        {
            itens.Add(new ItemPedido(produto, quantidade));
        }
    }

    public void RemoverItem(string codigoProduto)
    {
        var item = itens.Find(i => i.Produto.Codigo == codigoProduto);
        if (item != null)
            itens.Remove(item);
    }

    public void AlterarQuantidade(string codigoProduto, int novaQuantidade)
    {
        var item = itens.Find(i => i.Produto.Codigo == codigoProduto);
        if (item != null)
            item.Quantidade = novaQuantidade;
    }
}
