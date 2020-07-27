using Projeto.Escola.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Repository
{
    public class FuncionarioRepository
    {
        private readonly string connectionString;

        public FuncionarioRepository()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["aula"].ConnectionString;
        }

        public void Insert(Funcionario funcionario)
        {
            string query = "insert into Funcionario values (@Nome, @Salario, @IdEndereco)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                cmd.Parameters.AddWithValue("@IdEndereco", 1);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
