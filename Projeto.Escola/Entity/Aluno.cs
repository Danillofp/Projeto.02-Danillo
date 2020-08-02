using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Entity
{
    public class Aluno
    {
        private int idAluno;
        private string nome;
        private int idade;
        private Turma turma;
        private string matricula;

        public Aluno()
        {

        }

        public Aluno(string nome, int idade, Turma turma, string matricula)
        {
            Nome = nome;
            Idade = idade;
            Turma = turma;
            Matricula = matricula;
        }

        public int IdAluno { get => idAluno; set => idAluno = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public Turma Turma { get => turma; set => turma = value; }
        public string Matricula { get => matricula; set => matricula = value; }
    }
}
