using ClubeDaLeitura.ConsoleApp.Compartilhados;
using System.Collections;

namespace ClubeDaLeitura.ConsoleApp.MóduloRevista
{
    public class RepositorioRevista : RepositorioMae
    {

        public void AdicionarRevista(Revista revista)
        {
            revista.AtribuirId();
            registros.Add(revista);
        }

        public ArrayList ListarRevistas()
        {
            return registros;
        }

        public Revista ObterRevista(int id)
        {
            foreach (Revista revista in registros)
            {
                if (revista.id == id)
                {
                    return revista;
                }
            }
            return null;
        }

        public void AtualizaRevista(Revista revistaEncontrada, Revista revistaEditada)
        {
            revistaEncontrada.colecao = revistaEditada.colecao;
            revistaEncontrada.edicao = revistaEditada.edicao;
        }

        public void RemoverRevista(Revista revista)
        {
            registros.Remove(revista);
        }

    }
}
