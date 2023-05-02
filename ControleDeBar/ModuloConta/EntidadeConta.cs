using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public decimal ValorTotal;
        public Mesa Mesa;
        public Garcom Garcom;
        public ArrayList Pedidos;

        public Conta()
        {
        }

        public Conta(Mesa mesa, Garcom garcom, decimal valorTotal, ArrayList pedidos)
        {
            this.Mesa = mesa;
            this.Garcom = garcom;
            this.ValorTotal = valorTotal;
            this.Pedidos = pedidos;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;

            this.Mesa = contaAtualizada.Mesa;
            this.Garcom = contaAtualizada.Garcom;
            this.ValorTotal = contaAtualizada.ValorTotal;
            this.Pedidos = contaAtualizada.Pedidos;
        }
    }
}
