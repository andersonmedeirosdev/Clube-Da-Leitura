using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    public class Amigo
    {
        public string nome;
        public string nomeResponsavel;
        public string telefone;
        public string endereco;
        public int id;
        private static int contador = 1;

        public Amigo(string nome, string nomeResponsavel, string telefone, string endereco)
        {
            this.nome = nome;
            this.nomeResponsavel = nomeResponsavel;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public void AtribuirId()
        {
            id = contador++;
        }


        public override string ToString()
        {
            return $"Id: {id} Nome: {nome} Nome Responsável: {nomeResponsavel} Telefone: {telefone} Endereço: {endereco}";
        }

    }

}
