using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string Nome;
        public decimal Preco;

        public Produto()
        {
        }

        public Produto(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto ProdutoAtualizado = (Produto)registroAtualizado;

            this.Nome = ProdutoAtualizado.Nome;
            this.Preco = ProdutoAtualizado.Preco;
            
        }
    }
}
