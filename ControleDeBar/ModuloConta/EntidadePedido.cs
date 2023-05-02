using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class Pedido : EntidadeBase
    {
        public Produto Produto;
        public int Quantidade;
        public decimal ValorTotal;


        public Pedido(Produto produto, int quantidade, decimal valorTotal)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;

            valorTotal = produto.Preco * quantidade;

            this.ValorTotal = valorTotal;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado = (Pedido)registroAtualizado;

            this.Produto = pedidoAtualizado.Produto;
            this.Quantidade = pedidoAtualizado.Quantidade;
            this.ValorTotal = pedidoAtualizado.ValorTotal;

        }
    }
}
