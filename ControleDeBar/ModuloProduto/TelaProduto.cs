using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "Preco");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produto Produto in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", Produto.id, Produto.Nome, Produto.Preco);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());

            return new Produto(nome, preco);
        }
    }

}