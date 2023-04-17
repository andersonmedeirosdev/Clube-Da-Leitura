
namespace ClubeDaLeitura.ConsoleApp.MóduloCaixa
{
    public class Caixa
    {
        public string cor;
        public string etiqueta;
        public int id;
        private static int contador = 1;

        public Caixa(string cor, string etiqueta)
        {
            this.cor = cor;
            this.etiqueta = etiqueta;
        }

        public void AtribuirId()
        {
            id = contador++;
        }


        public override string ToString()
        {
            return $"Id: {id} | Cor: {cor} | Etiqueta: {etiqueta}";
        }
    }
}
