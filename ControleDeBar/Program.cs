using ControleDeBar.Compartilhado;
using ControleDeBar.Menu;
using ControleDeBar.ModuloConta;
using ControleDeBar.ModuloGarcom;
using ControleDeBar.ModuloMesa;
using ControleDeBar.ModuloProduto;
using System.Collections;

namespace ControleDeBar
{
    internal class Program
    {

        static void Main(string[] args)
        {

            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repoositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            PopularAplicacao(repositorioMesa, repoositorioProduto, repositorioGarcom);

            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repoositorioProduto);
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);

            TelaConta telaConta = new TelaConta(repositorioConta, telaMesa, telaGarcom, telaProduto);


            TelaPrincipal principal = new TelaPrincipal();

            while (true)
            {
                string opcao = principal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaConta.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaConta.ExcluirRegistro();
                    }
                }
                else if (opcao == "2")
                {
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }
                else if (opcao == "3")
                {
                    string subMenu = telaMesa.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                }

                else if (opcao == "4")
                {
                    string subMenu = telaProduto.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }
            }
        }

        private static void PopularAplicacao(RepositorioMesa repositorioMesa, RepositorioProduto repoositorioProduto, RepositorioGarcom repositorioGarcom)
        {
            Produto produto01 = new Produto("Cerveja", 12);
            Produto produto03 = new Produto("Água", 2);
            Produto produto02 = new Produto("Pinga", 15);
            Produto produto04 = new Produto("Refri", 10);

            Garcom garcom01 = new Garcom("Garçom1");
            Garcom garcom02 = new Garcom("Garçom2");

            Mesa mesa01 = new Mesa("01");
            Mesa mesa02 = new Mesa("02");

            repoositorioProduto.Inserir(produto01);
            repoositorioProduto.Inserir(produto02);
            repoositorioProduto.Inserir(produto03);
            repoositorioProduto.Inserir(produto04);

            repositorioMesa.Inserir(mesa01);
            repositorioMesa.Inserir(mesa02);

            repositorioGarcom.Inserir(garcom01);
            repositorioGarcom.Inserir(garcom02);
        }
    }
}
