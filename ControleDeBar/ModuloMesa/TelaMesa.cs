using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloConta;
using System.Collections;

namespace ControleDeBar.ModuloMesa
{
    public class TelaMesa : TelaBase
    {
        public TelaMesa(RepositorioMesa repositorioMesa)
        {
            this.repositorioBase = repositorioMesa;
            nomeEntidade = "Mesa";
            sufixo = "s";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Numero", "Ocupada");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesa Mesa in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}}", Mesa.id, Mesa.Numero, Mesa.Ocupada);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string numero = Console.ReadLine();

            return new Mesa(numero);
        }
    }

}