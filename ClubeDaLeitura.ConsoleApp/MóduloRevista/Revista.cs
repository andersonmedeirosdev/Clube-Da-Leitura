using ClubeDaLeitura.ConsoleApp.Compartilhados;
using ClubeDaLeitura.ConsoleApp.MóduloCaixa;

namespace ClubeDaLeitura.ConsoleApp.MóduloRevista
{
    public class Revista : Entidade
    {
        public string colecao;
        public string edicao;
        public Caixa caixa;
        //protected static int contador = 1;

        public Revista(string colecao, string edicao, Caixa caixa)
        {
            this.colecao = colecao;
            this.edicao = edicao;
            this.caixa = caixa;
        }

        public void Editar(Revista revista)
        {
            this.colecao = revista.colecao;
            this.edicao = revista.edicao;
            this.caixa = revista.caixa;
        }

        public override string ToString()
        {
            return $"Id: {id} | Coleção: {colecao} | Edição: {edicao} | Caixa: {caixa.etiqueta}";
        }
    }
}
