using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Entity
{
    public class Endereco
    {
        private int idEndereco;
        private string rua;
        private int numero;
        private string cep;
        private string complemento;

        public Endereco()
        {

        }

        public Endereco(string rua, int numero, string cep, string complemento)
        {
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Complemento = complemento;
        }

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Complemento { get => complemento; set => complemento = value; }
    }
}
