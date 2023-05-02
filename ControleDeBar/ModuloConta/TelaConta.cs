using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositorioConta;

        public RepositorioMesa repositorioMesa { get; }
        public RepositorioGarcom repositorioGarcom { get; }

        public TelaConta(RepositorioConta repositorioConta, RepositorioMesa repositorioMesa, RepositorioGarcom repositorioGarcom)
        {
            this.repositorioBase = repositorioConta;
            nomeEntidade = "Conta";
            sufixo = "s";
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
        }

        public TelaConta(RepositorioConta repositorioConta)
        {
            this.repositorioConta = repositorioConta;
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", "Id", "Mesa", "Garçom", "Valor");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Conta Conta in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20} | {3, -20}", Conta.id, Conta.Mesa, Conta.Garcom, Conta.ValorTotal);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Mesa mesa = ObterMesa();

            Garcom garcom = (Garcom)ObterRegistro();

            int valorTotal = 0;

            ArrayList pedidos = new ArrayList();

            return new Conta(mesa, garcom, valorTotal, pedidos);
        }

        public Mesa ObterMesa()
        {
            Console.WriteLine("Qual o id da mesa?");
            int id = Convert.ToInt32(Console.ReadLine());
            Mesa mesa = repositorioMesa.SelecionarPorId(id);

            Console.WriteLine();

            return mesa;
        }

        public Garcom ObterGarcom()
        {
            Console.WriteLine();

            Console.WriteLine("Qual o id do Garcom?");
            int id = Convert.ToInt32(Console.ReadLine());
            Garcom garcom = repositorioGarcom.SelecionarPorId(id);

            Console.WriteLine();

            return garcom;
        }
    }

}