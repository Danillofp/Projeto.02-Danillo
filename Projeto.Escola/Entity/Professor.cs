using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Entity
{
    public class Professor : Funcionario
    {
        private string disciplina;

        public Professor()
        {

        }

        public Professor(string nome, double salario, Endereco endereco, string disciplina)
            : base(nome, salario, endereco)
        {
            Disciplina = disciplina;
        }

        public string Disciplina { get => disciplina; set => disciplina = value; }
    }
}
