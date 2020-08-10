using Projeto.Escola.Entity;
using Projeto.Escola.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Endereco obj = new Endereco();
            obj.Rua = "Rue Cadillac";
            obj.Numero = 4020;
            obj.Cep = "H1R1H8";
            obj.Complemento = "Proximo ao metro Cadillac";
            obj.IdEndereco = 1;

            EnderecoRepository rep = new EnderecoRepository();
            //rep.Insert(obj);
            Console.WriteLine("Endereço gravado com sucesso!");

            List<Endereco> lista = rep.SelectAll();
            foreach(var item in lista)
            {
                Console.WriteLine("Rua: " + item.Rua);
                Console.WriteLine("Numero: " + item.Numero);
                Console.WriteLine("Cep: " + item.Cep);
                Console.WriteLine("Complemento: " + item.Complemento);
                Console.WriteLine("*********************************");
            }

            Professor professor = new Professor("Luka", 20.00, obj, "programacao");
            Professor professor1 = new Professor("Joao", 15.00, obj, "matematica");


            ProfessorRepository profrep = new ProfessorRepository();
            profrep.Insert(professor1);

            List<Professor> proflista = profrep.SelectAll();
            foreach (var item in proflista)
            {
                Console.WriteLine("Nome: " + item.Nome);
                Console.WriteLine("Salario: " + item.Salario);
                Console.WriteLine("Endereco: " + item.Endereco.Rua + "\n" + item.Endereco.Numero);
                Console.WriteLine("Disciplina: " + item.Disciplina);
                Console.WriteLine("*********************************");
            }

            Console.ReadKey();
        }
    }
}
