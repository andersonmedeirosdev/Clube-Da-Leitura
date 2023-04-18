using ClubeDaLeitura.ConsoleApp.MóduloCaixa;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.MóduloRevista
{
    public class CadastroRevista
    {
        public RepositorioRevista repositorioRevista;
        public RepositorioCaixa repositorioCaixa;

        public CadastroRevista(RepositorioRevista repositorioRevista, RepositorioCaixa repositorioCaixa)
        {
            this.repositorioRevista = repositorioRevista;
            this.repositorioCaixa = repositorioCaixa;
        }

        public Revista FormularRevista()
        {
            Console.Clear();
            ArrayList caixas = repositorioCaixa.ListarTodos();
            foreach(Caixa item in caixas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCAIXAS DISPONÍVEIS");

            Console.WriteLine("Insira os dados abaixo para cadastrar a Revista:");
            Console.Write("Coleção: ");
            string colecao = Console.ReadLine();
            Console.Write("Ano: ");
            string edicao = Console.ReadLine();
            Console.Write("Numero da Caixa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Caixa caixa = (Caixa)repositorioCaixa.ObterPorId(id);
            return new Revista(colecao, edicao, caixa);
        }

        public void CadastrarRevista()
        {
            Revista revista = FormularRevista();
            repositorioRevista.Adicionar(revista);
        }

        public void MostrarMenuRevista()
        {
                Console.Clear();

                Console.WriteLine("--MENU REVISTA--");
                Console.WriteLine("[1] PARA CADASTRAR");
                Console.WriteLine("[2] PARA VISUALIZAR");
                Console.WriteLine("[3] PARA EDITAR");
                Console.WriteLine("[4] PARA EXCLUIR");
                Console.WriteLine("[5] PARA SAIR");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    CadastrarRevista();
                }
                else if (opcao == "2")
                {
                    MostrarRevistas();
                }
                else if (opcao == "3")
                {
                    EditarRevistas();
                }
                else if (opcao == "4")
                {
                    ExcluirRevistas();
                }
        }

        public void MostrarRevistas()
        {
            Console.WriteLine("REVISTAS CADASTRADAS");
            ArrayList revistas = repositorioRevista.ListarTodos();
            if(revistas.Count == 0)
            {
                Console.WriteLine("Nenhuma revista cadastrada...");
            }
            foreach (var item in revistas)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void EditarRevistas()
        {
            MostrarRevistas();

            Console.Clear();
            Console.WriteLine("ATUALIZAR REVISTAS");
            Console.WriteLine("Digite um Id para Editar:");
            int id = Convert.ToInt32(Console.ReadLine());
            var revistaEncontrada = (Revista)repositorioRevista.ObterPorId(id);
            if(revistaEncontrada == null)
            {
                Console.WriteLine("Revista não encontrada...");
                return;
            }
            Revista revistaEditada = FormularRevista();
            revistaEncontrada.Editar(revistaEditada);
        }

        public void ExcluirRevistas()
        {
            MostrarRevistas();

            Console.Clear();
            Console.WriteLine("EXCLUIR REVISTAS");
            Console.WriteLine("Digite um Id para Editar:");
            int id = Convert.ToInt32(Console.ReadLine());
            var revistaEncontrada = repositorioRevista.ObterPorId(id);
            if (revistaEncontrada == null)
            {
                Console.WriteLine("Revista não encontrada...");
                return;
            }

            repositorioRevista.Remover(revistaEncontrada);
        }
    }
}
