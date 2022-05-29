using MySql.Data.MySqlClient;

namespace ProfessorBancoDeDados
{
    class metodosProfessor
    {
        public static void inserirProfessor(Professor novoProfessor)
        {
            if (bancoDeDados.AbrirConexao())
            {
                string sql = $"INSERT INTO professores VALUES ({novoProfessor.getCodigo()}, '{novoProfessor.getNome()}', '{novoProfessor.getTitulacao()}',{novoProfessor.getHoras()})";
                MySqlCommand comando = new MySqlCommand(sql, bancoDeDados.GetConexao());
                comando.ExecuteNonQuery();
                bancoDeDados.FecharConexao();
                Console.WriteLine($"Professor {novoProfessor.getNome()} adicionado ao banco de dados com sucesso");
            }
            else
            {
                Console.WriteLine("Não foi possível adicionar o professor ao banco de dados");
            }
        }

        public static void consultarProfessor(int codigo)
        {
            string sql = $"";
        }
    }
}
