﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Entity
{
    public class Professor
    {
        private int idProfessor;
        private string disciplina;
        private int idFuncionario;

        public string Disciplina { get => disciplina; set => disciplina = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public int IdProfessor { get => idProfessor; set => idProfessor = value; }
    }
}
