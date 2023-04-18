
using ClubeDaLeitura.ConsoleApp.Compartilhados;

namespace ClubeDaLeitura.ConsoleApp.MóduloCaixa
{
    public class Caixa : Entidade
    {
        public string cor;
        public string etiqueta;
        protected static int contador = 1;

        public Caixa(string cor, string etiqueta)
        {
            this.cor = cor;
            this.etiqueta = etiqueta;
        }

        public void Editar(Caixa caixa)
        {
            this.cor = caixa.cor;
            this.etiqueta = caixa.etiqueta;
        }

        public override string ToString()
        {
            return $"Id: {id} | Cor: {cor} | Etiqueta: {etiqueta}";
        }
    }
}
