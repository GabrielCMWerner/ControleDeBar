using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ModuloGarcom
{
    public class TelaGarcom : TelaBase
    {
        public TelaGarcom(RepositorioGarcom repositorioGarcom)
        {
            this.repositorioBase = repositorioGarcom;
            nomeEntidade = "Garçom";
            sufixo = "(s)";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20}", "Id", "Nome");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Garcom Garcom in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20}", Garcom.id, Garcom.Nome);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            return new Garcom(nome);
        }
    }

}