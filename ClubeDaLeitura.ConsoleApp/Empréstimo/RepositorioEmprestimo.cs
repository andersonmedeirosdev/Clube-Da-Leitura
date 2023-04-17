using ClubeDaLeitura.ConsoleApp.MóduloRevista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp.Empréstimo
{
    public class RepositorioEmprestimo
    {
        private static ArrayList emprestimos = new ArrayList();

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            emprestimo.AtribuirId();
            emprestimos.Add(emprestimo);
        }

        public ArrayList ListarEmprestimos()
        {
            return emprestimos;
        }

    }
}
