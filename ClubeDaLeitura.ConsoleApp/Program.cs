using System.Collections;
using ClubeDaLeitura.ConsoleApp.Empréstimo;
using ClubeDaLeitura.ConsoleApp.MóduloAmigo;
using ClubeDaLeitura.ConsoleApp.MóduloCaixa;
using ClubeDaLeitura.ConsoleApp.MóduloRevista;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioAmigos repositorioAmigos = new RepositorioAmigos();
            CadastroAmigo cadastroAmigo = new CadastroAmigo(repositorioAmigos);
            RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
            CadastroCaixa cadastroCaixa = new CadastroCaixa(repositorioCaixa);
            RepositorioRevista repositorioRevista = new RepositorioRevista();
            CadastroRevista cadastroRevista = new CadastroRevista(repositorioRevista, repositorioCaixa);
            RepositorioEmprestimo repositorioEmprestimo = new RepositorioEmprestimo();
            CadastroEmprestimo cadastroEmprestimo = new CadastroEmprestimo(repositorioEmprestimo, repositorioAmigos, repositorioRevista);

            do
            {
                Console.Clear();

                Console.WriteLine("--MENU DE OPÇÕES--");
                Console.WriteLine("([1] PARA MENU AMIGOS");
                Console.WriteLine("([2] PARA MENU CAIXAS");
                Console.WriteLine("([3] PARA MENU REVISTAS");
                Console.WriteLine("([4] PARA MENU EMPRÉSTIMOS");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    cadastroAmigo.MostrarMenuAmigo();
                }
                else if (opcao == "2")
                {
                    cadastroCaixa.MostrarMenuCaixa();
                }
                else if (opcao == "3")
                {
                    cadastroRevista.MostrarMenuRevista();
                }
                else if (opcao == "4")
                {
                    cadastroEmprestimo.MostrarMenuEmprestimos();
                }
                Console.Clear();

                Console.ReadLine();
            } while (true);
        }

    }
}