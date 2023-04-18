using ClubeDaLeitura.ConsoleApp.Compartilhados;
using ClubeDaLeitura.ConsoleApp.MóduloCaixa;
using ClubeDaLeitura.ConsoleApp.MóduloRevista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Empréstimo
{
    public class Emprestimo : Entidade
    {
        public Amigo amigo;
        public Revista revista;
        //protected static int contador = 1;
        public DateTime dataEmprestimo;
        public DateTime dataDevolucao;

        public Emprestimo(Amigo amigo, Revista revista)
        {
            this.amigo = amigo;
            this.revista = revista;
            this.dataEmprestimo = DateTime.Now;
            this.dataDevolucao = DateTime.Now.AddDays(5);
        }

        public override string ToString()
        {
            return $"Id: {id} | Amigo: {this.amigo.nome} | Caixa: {this.revista.colecao} | Data Empréstimo: {dataEmprestimo} | Data Devolução: {dataDevolucao}";
        }
    }
}
