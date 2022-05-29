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

        public static String consultarProfessor(int codigo)
        {
            //Não está sendo possível realizar consultas repetidas vezes

            //List<Professor> professoresAchados = new List<Professor>();
            //int cont = 0;
            if (bancoDeDados.AbrirConexao())
            {
                MySqlCommand comando = new MySqlCommand($"SELECT nome, titulacao, horas FROM professores WHERE CODIGO = {codigo}", bancoDeDados.GetConexao());
                MySqlDataReader reader = comando.ExecuteReader();
                Professor achado = new Professor();

                while (reader.Read())
                {
                    achado.setNome(reader.GetString("nome"));
                    achado.setTitulacao(reader.GetString("titulacao"));
                    achado.setHoras(reader.GetInt32("horas"));
                    //cont++;
                }
                return $"Nome: {achado.getNome()} \n Titulação: {achado.getTitulacao()} \n Horas: {achado.getHoras()}";
            }
            else
            {
                return "Professor não encontrado";
            }
        }

        public static String ExcluirProfessor(int codigo)
        {
            if (bancoDeDados.AbrirConexao())
            {
                MySqlCommand comando = new MySqlCommand($"DELETE FROM professores WHERE CODIGO = {codigo}", bancoDeDados.GetConexao());
                //return consultarProfessor(codigo) + "Foi deletado do sistema.";
                MySqlDataReader reader = comando.ExecuteReader();
                return $"Professor com o código {codigo} foi deletado do sistema";
            }
            else return "Professor não encontrado.";
        }


    }
}
