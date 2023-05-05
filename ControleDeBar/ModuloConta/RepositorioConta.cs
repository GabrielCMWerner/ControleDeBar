using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaConta)
        {
            this.listaRegistros = listaConta;
        }

        public ArrayList SelecionarContasEmAberto()
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if (conta.EstaAberta)
                    contasEmAberto.Add(conta);
            }

            return contasEmAberto;
        }

        public ArrayList SelecionarContasFechadas(DateTime data)
        {
            ArrayList contasEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if (conta.EstaAberta == false && conta.Data.Date == data.Date)
                    contasEmAberto.Add(conta);
            }

            return contasEmAberto;
        }
    }

}