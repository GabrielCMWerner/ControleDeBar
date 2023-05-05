using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Mesa Mesa;
        public Garcom Garcom;
        public ArrayList Pedidos;

        public bool EstaAberta;

        public DateTime Data;

        public Conta(Mesa m, Garcom g, DateTime dataAbertura)
        {
            Mesa = m;
            Garcom = g;
            Pedidos = new ArrayList();
            Data = dataAbertura;

            Abrir();
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;

            Garcom = contaAtualizada.Garcom;
            Mesa = contaAtualizada.Mesa;
        }

        public void RegistrarPedido(Produto produto, int quantidadeEscolhida)
        {
            Pedido novoPedido = new Pedido(produto, quantidadeEscolhida);

            Pedidos.Add(novoPedido);
        }

        public decimal CalcularValorTotal()
        {
            decimal total = 0;

            foreach (Pedido pedido in Pedidos)
            {
                decimal totalPedido = pedido.CalcularTotalParcial();

                total += totalPedido;
            }

            return total;
        }
        private void Abrir()
        {
            EstaAberta = true;
            Mesa.Ocupar();
        }

        public void Fechar()
        {
            EstaAberta = false;
            Mesa.Desocupar();
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (Garcom == null)
            {
                erros.Add("O campo \"Garçom\" é obrigatorio");
            }

            if (Mesa == null)
            {
                erros.Add("O campo \"Mesa\" é obrigatorio");
            }

            return erros;
        }
    }
}
