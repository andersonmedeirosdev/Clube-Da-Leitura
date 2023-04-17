using ClubeDaLeitura.ConsoleApp.Compartilhados;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.MóduloCaixa
{
    public class RepositorioCaixa : RepositorioMae
    {


        public void AdicionarCaixa(Caixa caixa)
        {
            caixa.AtribuirId();
            registros.Add(caixa);
        }

        public ArrayList ListarCaixas()
        {
            return registros;
        }

        public Caixa ObterCaixa(int id)
        {
            foreach (Caixa caixa in registros)
            {
                if (caixa.id == id)
                {
                    return caixa;
                }
            }
            return null;
        }

        public void AtualizaCaixa(Caixa caixaEncontrada, Caixa caixaEditada)
        {
            caixaEncontrada.cor = caixaEditada.cor;
            caixaEncontrada.etiqueta = caixaEditada.etiqueta;
        }

        public void RemoverCaixa(Caixa caixa)
        {
            registros.Remove(caixa);
        }
    }
}
