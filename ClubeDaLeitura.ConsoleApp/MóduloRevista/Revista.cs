using ClubeDaLeitura.ConsoleApp.MóduloCaixa;

namespace ClubeDaLeitura.ConsoleApp.MóduloRevista
{
    public class Revista
    {
        public string colecao;
        public int id;
        public string edicao;
        public int contador = 1;
        public Caixa caixa;

        public Revista(string colecao, string edicao, Caixa caixa)
        {
            this.colecao = colecao;
            this.edicao = edicao;
            this.caixa = caixa;
        }


        public void AtribuirId()
        {
            id = contador++;
        }

        public override string ToString()
        {
            return $"Id: {id} | Coleção: {colecao} | Edição: {edicao} | Caixa: {caixa.etiqueta}";
        }
    }
}
