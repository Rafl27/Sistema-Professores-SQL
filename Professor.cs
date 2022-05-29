namespace ProfessorBancoDeDados
{
    public class Professor
    {
        private int codigo;
        private String nome;
        private String titulacao;
        private int horas;

        public Professor(int codigo, string nome, string titulacao, int horas)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.titulacao = titulacao;
            this.horas = horas;
        }

        public Professor()
        {

        }

        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return nome;
        }

        public void setTitulacao(String titulacao)
        {
            this.titulacao = titulacao;
        }

        public String getTitulacao()
        {
            return titulacao;
        }

        public void setHoras(int horas)
        {
            this.horas = horas;
        }

        public int getHoras()
        {
            return horas;
        }
    }
}
