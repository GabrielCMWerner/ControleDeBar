namespace ControleDeBar.Menu
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Controle de Bar\n");

            Console.WriteLine("Digite 1 para Cadastrar Conta");
            Console.WriteLine("Digite 2 para Cadastrar Garçom");
            Console.WriteLine("Digite 3 para Cadastrar Mesa");
            Console.WriteLine("Digite 4 para Cadastrar Produto");



            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}