using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class FaturamentoDiario
    {
        private ArrayList contasFechadas;

        public FaturamentoDiario(ArrayList contas)
        {
            this.contasFechadas = contas;
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (Conta conta in contasFechadas)
            {
                total += conta.CalcularValorTotal();
            }

            return total;
        }
    }
}
