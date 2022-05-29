using MySql.Data.MySqlClient;

namespace ProfessorBancoDeDados
{
    class bancoDeDados
    {
        private static MySqlConnection conexao = new MySqlConnection(
            "Persist Security Info=False;" +
            "Server=127.0.0.1;" +    //Servidor
            "Database=professor;" + //Banco de dados
            "uid=root;" +           //username
            "pwd=1234;");           //senha

        public static Boolean AbrirConexao()
        {
            try
            {
                conexao.Open(); //Abre a conexão
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean FecharConexao()
        {
            //Verifica se a conexão esta aberta
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close(); //Fecha a conexão
                return true;
            }
            else
                return false;
        }

        public static MySqlConnection GetConexao()
        {
            return conexao;
        }

        public static void InserirProfessor()
        {
            if (bancoDeDados.AbrirConexao())
            {
                string sql = "INSERT INTO professores VALUES(1, 'rafael', 'ingles', 20)";
                MySqlCommand comando = new MySqlCommand(sql, bancoDeDados.GetConexao());
                comando.ExecuteNonQuery();
                bancoDeDados.FecharConexao();
            }
            else
            {
                Console.WriteLine("Não foi possível conectar ao banco de dados");
            }
        }
    }
}
