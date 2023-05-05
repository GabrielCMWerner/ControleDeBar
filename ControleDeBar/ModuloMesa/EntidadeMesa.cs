using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloConta;
using System.Collections;

namespace ControleDeBar.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string Numero;
        public bool Ocupada;

        public Mesa(string numeroMesa)
        {
            Numero = numeroMesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            this.Numero = mesaAtualizada.Numero;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(Numero.Trim()))
            {
                erros.Add("O campo \"Número da Mesa\" é obrigatorio");
            }
            return erros;
        }

        public void Desocupar()
        {
            Ocupada = false;
        }

        public void Ocupar()
        {
            Ocupada = true;
        }
    }
}
