using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Entity
{
    public abstract class Funcionario
    {
        private int idFuncionario;
        private string nome;
        private double salario;
        private Endereco endereco;

        public Funcionario()
        {

        }

        public Funcionario(string nome, double salario, Endereco endereco)
        {
            Nome = nome;
            Salario = salario;
            Endereco = endereco;
        }

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
    }
}
