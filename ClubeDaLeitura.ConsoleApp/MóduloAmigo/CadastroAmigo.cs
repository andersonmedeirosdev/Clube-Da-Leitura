using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.MóduloAmigo
{
    public class CadastroAmigo
    {
        private RepositorioAmigos repositorioAmigos;

        public CadastroAmigo(RepositorioAmigos repositorioAmigos)
        {
            this.repositorioAmigos = repositorioAmigos;
        }

        public Amigo FormularAmigo()
        {
            Console.Clear();
            Console.WriteLine("Insira os dados abaixo para cadastrar o/a Amigo/a:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nome do responsável: ");
            string nomeResponsavel = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            return new Amigo(nome, nomeResponsavel, telefone, endereco);
        }

        public void CadastrarAmigo()
        {
            Amigo amigo = FormularAmigo();
            repositorioAmigos.AdicionarAmigo(amigo);
        }

        public void MostrarMenuAmigo()
        {
                Console.Clear();
                Console.WriteLine("--MENU AMIGOS--");
                Console.WriteLine("([1] PARA CADASTRAR");
                Console.WriteLine("([2] PARA VISUALIZAR");
                Console.WriteLine("([3] PARA EDITAR");
                Console.WriteLine("([4] PARA EXCLUIR");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    CadastrarAmigo();
                }
                else if (opcao == "2")
                {
                    MostrarAmigos();
                }
                else if (opcao == "3")
                {
                    EditarAmigo();
                }
                else if (opcao == "4")
                {
                    ExcluirAmigo();
                }
        }

        public void MostrarAmigos()
        {
            Console.WriteLine("AMIGOS CADASTRADOS");
            ArrayList amigos = repositorioAmigos.ListarAmigos();
            if (amigos.Count == 0)
            {
                Console.WriteLine("Nenhum amigo cadastrado...");
            }
            foreach (var item in amigos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private void EditarAmigo()
        {
            MostrarAmigos();

            Console.Clear();
            Console.WriteLine("ATUALIZAR AMIGO");
            Console.WriteLine("Digite um Id para Editar:");
            int id = Convert.ToInt32(Console.ReadLine());
            var amigoEncontrado = repositorioAmigos.ObterAmigo(id);
            if (amigoEncontrado == null)
            {
                Console.WriteLine("Amigo não encontrado");
                return;
            }
            Amigo amigoEditado = FormularAmigo();

            repositorioAmigos.AtualizaAmigo(amigoEncontrado, amigoEditado);
        }

        private void ExcluirAmigo()
        {
            MostrarAmigos();

            Console.Clear();
            Console.WriteLine("EXCLUIR AMIGO");
            Console.WriteLine("Digite um Id para Excluir:");
            int id = Convert.ToInt32(Console.ReadLine());
            var amigoEncontrado = repositorioAmigos.ObterAmigo(id);

            if (amigoEncontrado == null)
            {
                Console.WriteLine("Amigo não encontrado");
                Console.ReadLine();
                return;
            }

            repositorioAmigos.RemoverAmigo(amigoEncontrado);
        }
    }
}
