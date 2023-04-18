using ClubeDaLeitura.ConsoleApp.MóduloAmigo;
using ClubeDaLeitura.ConsoleApp.MóduloCaixa;
using ClubeDaLeitura.ConsoleApp.MóduloRevista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Empréstimo
{
    public class CadastroEmprestimo
    {
        public RepositorioEmprestimo repositorioEmprestimo;
        public RepositorioRevista repositorioRevista;
        public RepositorioAmigos repositorioAmigo;

        public CadastroEmprestimo(RepositorioEmprestimo repositorioEmprestimo, RepositorioAmigos repositorioAmigos, RepositorioRevista repositorioRevista)
        {
            this.repositorioEmprestimo = repositorioEmprestimo;
            this.repositorioRevista = repositorioRevista;
            this.repositorioAmigo = repositorioAmigos;
        }
        
        public Emprestimo FormularEmprestimo()
        {
            Console.Clear();
            ArrayList amigos = repositorioAmigo.ListarTodos();
            foreach(Amigo item in amigos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            ArrayList revista = repositorioRevista.ListarTodos();
            foreach(Revista item in revista)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("CADASTRO EMPRÉSTIMOS");

            Console.WriteLine("Insira os dados abaixo para cadastrar o Empréstimo:");
            Console.Write("Número do Amigo: ");
            int idAmigo = Convert.ToInt32(Console.ReadLine());
            Amigo amigo = (Amigo)repositorioAmigo.ObterPorId(idAmigo);
            Console.Write("Número da Caixa: ");
            int idRevista = Convert.ToInt32(Console.ReadLine());
            Revista revistaEncontrada = (Revista)repositorioRevista.ObterPorId(idRevista);
            return new Emprestimo(amigo, revistaEncontrada);
        }

        public void CadastrarEmprestimo()
        {
            Emprestimo emprestimo = FormularEmprestimo();
            repositorioEmprestimo.Adicionar(emprestimo);
        }

        public void MostrarEmprestimos()
        {
            Console.WriteLine("EMPRÉSTIMOS CADASTRADOS");
            ArrayList emprestimos = repositorioEmprestimo.ListarTodos();
            if(emprestimos.Count == 0)
            {
                Console.WriteLine("No momento não temos empréstimos cadastrados...");
            }
            foreach(Emprestimo emprestimo in emprestimos)
            {
                Console.WriteLine(emprestimo);
            }
            Console.ReadLine();
        }

        public void MostrarMenuEmprestimos()
        {
            Console.Clear();

            Console.WriteLine("--MENU EMPRÉSTIMOS--");
            Console.WriteLine("[1] PARA CADASTRAR");
            Console.WriteLine("[2] PARA VISUALIZAR");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                CadastrarEmprestimo();
            }
            else if (opcao == "2")
            {
                MostrarEmprestimos();
            }
        }
    }
}
