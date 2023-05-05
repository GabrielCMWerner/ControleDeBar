using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class Pedido
    {
        public static int ContadorId;
        public int Id;
        public Produto Produto;
        public int QuantidadeSolicitada;



        public Pedido(Produto produto, int quantidadeEscolhida)
        {
            ContadorId++;
            Id = ContadorId;

            this.Produto = produto;
            this.QuantidadeSolicitada = quantidadeEscolhida;
        }

        public decimal CalcularTotalParcial()
        {
            return Produto.Preco * QuantidadeSolicitada;
        }
    }
}
