using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.MóduloCaixa
{
    public class CadastroCaixa
    {
        private RepositorioCaixa repositorioCaixa;
        public CadastroCaixa(RepositorioCaixa repositorioCaixa1)
        {
            this.repositorioCaixa = repositorioCaixa1;
        }

        public Caixa FormularCaixa()
        {
            Console.Clear();

            Console.WriteLine("Insira os dados abaixo para cadastrar a Caixa:");
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.Write("número de etiqueta: ");
            string etiqueta = Console.ReadLine();
            return new Caixa(cor, etiqueta);
        }

        public void CadastrarCaixa()
        {
            Caixa caixa = FormularCaixa();
            repositorioCaixa.AdicionarCaixa(caixa);
        }

        public  void MostrarMenuCaixa()
        {
                Console.Clear();

                Console.WriteLine("--MENU CAIXAS--");
                Console.WriteLine("[1] PARA CADASTRAR");
                Console.WriteLine("[2] PARA VISUALIZAR");
                Console.WriteLine("[3] PARA EDITAR");
                Console.WriteLine("[4] PARA EXCLUIR");
                Console.WriteLine("[5] PARA SAIR");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    CadastrarCaixa();
                }
                else if (opcao == "2")
                {
                    MostrarCaixas();
                }
                else if (opcao == "3")
                {
                    EditarCaixas();
                }
                else if (opcao == "4")
                {
                    ExcluirCaixa();
                }
        }

        public void MostrarCaixas()
        {
            Console.Clear();
            Console.WriteLine("CAIXAS CADASTRADAS");
            ArrayList caixas = repositorioCaixa.ListarCaixas();
            if (caixas.Count == 0)
            {
                Console.WriteLine("Nenhuma caixa cadastrada...");
            }
            foreach (var item in caixas)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void EditarCaixas()
        {
            MostrarCaixas();

            Console.Clear();
            Console.WriteLine("ATUALIZAR CAIXA");
            Console.WriteLine("Digite um Id para editar:");
            int id = Convert.ToInt32(Console.ReadLine());
            var caixaEncontrada = repositorioCaixa.ObterCaixa(id);
            if (caixaEncontrada == null)
            {
                Console.WriteLine("Caixa não encontrada...");
                return;
            }
            Caixa caixaEditada = FormularCaixa();

            repositorioCaixa.AtualizaCaixa(caixaEncontrada, caixaEditada);
        }

        private void ExcluirCaixa()
        {
            MostrarCaixas();

            Console.Clear();
            Console.WriteLine("EXCLUIR CAIXA");
            Console.WriteLine("Digite um Id para Excluir:");
            int id = Convert.ToInt32(Console.ReadLine());
            var caixaEncontrada = repositorioCaixa.ObterCaixa(id);

            if (caixaEncontrada == null)
            {
                Console.WriteLine("Caixa não encontrada...");
                Console.ReadLine();
                return;
            }

            repositorioCaixa.RemoverCaixa(caixaEncontrada);
        }
    }
}
