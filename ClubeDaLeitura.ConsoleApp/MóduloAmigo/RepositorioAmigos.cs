using ClubeDaLeitura.ConsoleApp.Compartilhados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.MóduloAmigo
{
    public class RepositorioAmigos : RepositorioMae
    {
        private ArrayList amigos = new ArrayList();

        public void AdicionarAmigo(Amigo amigo)
        {
            amigo.AtribuirId();
            amigos.Add(amigo);
        }

        public ArrayList ListarAmigos()
        {
            return amigos;
        }

        public Amigo ObterAmigo(int id)
        {
            foreach (Amigo amigo in amigos)
            {
                if (amigo.id == id)
                {
                    return amigo;
                }
            }
            return null;
        }

        public void AtualizaAmigo(Amigo amigoEncontrado, Amigo amigoEditado)
        {
            amigoEncontrado.nome = amigoEditado.nome;
            amigoEncontrado.nomeResponsavel = amigoEditado.nomeResponsavel;
            amigoEncontrado.telefone = amigoEditado.telefone;
            amigoEncontrado.endereco = amigoEditado.endereco;
        }

        public void RemoverAmigo(Amigo amigo)
        {
            amigos.Remove(amigo);
        }
    }
}
