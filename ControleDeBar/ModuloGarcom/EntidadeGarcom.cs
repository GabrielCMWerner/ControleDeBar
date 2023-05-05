using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Nome;

        public Garcom()
        {
        }

        public Garcom(string nome)
        {
            this.Nome = nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom ProdutoAtualizado = (Garcom)registroAtualizado;

            this.Nome = ProdutoAtualizado.Nome;
            
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(Nome.Trim()))
            {
                erros.Add("O campo \"Nome\" é obrigatório");
            }

            return erros;
        }
    }
}
