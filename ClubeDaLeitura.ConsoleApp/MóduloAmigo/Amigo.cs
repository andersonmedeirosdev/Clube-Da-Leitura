using ClubeDaLeitura.ConsoleApp.Compartilhados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Amigo : Entidade
    {
        public string nome;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;
        protected static int contador = 1;

        public Amigo(string nome, string nomeResponsavel, string telefone, string endereco)
        {
            this.nome = nome;
            this.nomeResponsavel = nomeResponsavel;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public void EditarAmigo(Amigo amigo)
        {
            this.nome = amigo.nome;
            this.nomeResponsavel = amigo.nomeResponsavel;
            this.telefone = amigo.telefone;
            this.endereco = amigo.endereco;
        }

        public override string ToString()
        {
            return $"Id: {id} | Nome: {nome} | Nome Responsável: {nomeResponsavel} | Telefone: {telefone} | Endereço: {endereco}";
        }

    }

}
