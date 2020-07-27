using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Entity
{
    public class Turma
    {
        private int idTurma;
        private string codigo;

        public string Codigo { get => codigo; set => codigo = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }
    }
}
