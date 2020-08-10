using Projeto.Escola.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Escola.Repository
{
    public class ProfessorRepository
    {
        private readonly string connectionString;

        public ProfessorRepository()
        {
            connectionString = ConfigurationManager
                .ConnectionStrings["aula"].ConnectionString;
        }

        public void Insert(Professor professor)
        {
            string query = "insert into professor values(@Nome, @Salario, @IdEndereco, @Disciplina);" +
               "SELECT CAST(scope_identity() AS int)";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", professor.Nome);
                cmd.Parameters.AddWithValue("@Salario", professor.Salario);
                cmd.Parameters.AddWithValue("@IdEndereco", professor.Endereco.IdEndereco);
                cmd.Parameters.AddWithValue("@Disciplina", professor.Disciplina);
                professor.IdFuncionario = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public List<Professor> SelectAll()
        {
            string query = "select * from professor p inner join endereco e " +
                "on p.IdEndereco = e.IdEndereco";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<Professor> lista = new List<Professor>();

                while (reader.Read())
                {
                    Professor professor = new Professor();
                    professor.Endereco = new Endereco();

                    professor.IdFuncionario = Convert.ToInt32(reader["IdFuncionario"]);
                    professor.Nome = Convert.ToString(reader["Nome"]);
                    professor.Salario = Convert.ToDouble(reader["Salario"]);
                    professor.Disciplina = Convert.ToString(reader["Disciplina"]);
                    professor.Endereco.IdEndereco = Convert.ToInt32(reader["IdEndereco"]);
                    professor.Endereco.Rua = Convert.ToString(reader["Rua"]);
                    professor.Endereco.Numero = Convert.ToInt32(reader["Numero"]);
                    professor.Endereco.Complemento = Convert.ToString(reader["Complemento"]);
                    lista.Add(professor);
                }
                return lista;
            }


        }

        public Professor SelectById(int id)
        {
            string query = "select * from professor where idFuncionario = @id";
            using (SqlConnection con = new SqlConnection(connectionString))
            {

            }
        }
    }
}
