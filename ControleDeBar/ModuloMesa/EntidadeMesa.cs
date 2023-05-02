using ControleDeBar.Compartilhado;
using ControleDeBar.ModuloConta;
using System.Collections;

namespace ControleDeBar.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string Numero;
        public bool Status;

        public Mesa()
        {
        }

        public Mesa(string numero, bool status)
        {
            this.Numero = numero;
            this.Status = status;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa MesaAtualizada = (Mesa)registroAtualizado;

            this.Numero = MesaAtualizada.Numero;
            this.Status = MesaAtualizada.Status;

        }
    }
}
