namespace ProfessorBancoDeDados
{
    class Program
    {
        public static void Main()
        {
            bool menu = true;
            bool menu2 = true;
            int op;
            while (menu)
            {
                Console.WriteLine("\n\n\n------MENU------");
                Console.WriteLine("1. Adicionar professor");
                Console.WriteLine("2. Consultar professor");
                Console.WriteLine("3. Excluir professor");
                Console.WriteLine("4. Gerar folha de pagamento");
                Console.WriteLine("5. Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Professor novoProfessor = new Professor();
                        Console.Write("Nome do professor: ");
                        novoProfessor.setNome(Console.ReadLine());
                        Console.Write("Código do professor: ");
                        novoProfessor.setCodigo(Convert.ToInt32(Console.ReadLine()));
                        while (menu2)
                        {
                            Console.WriteLine("Titulação do professor: ");
                            Console.WriteLine("1. Especialista");
                            Console.WriteLine("2. Mestre");
                            Console.WriteLine("3. Doutor");
                            int titulacaoOP = Convert.ToInt32(Console.ReadLine());
                            switch (titulacaoOP)
                            {
                                case 1:
                                    novoProfessor.setTitulacao("Especialista");
                                    menu2 = false;
                                    break;
                                case 2:
                                    novoProfessor.setTitulacao("Mestre");
                                    menu2 = false;
                                    break;
                                case 3:
                                    novoProfessor.setTitulacao("Doutor");
                                    menu2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Titulação inexistente...");
                                    break;
                            }
                        }
                        Console.Write("Quantidade de horas lecionadas por semana: ");
                        novoProfessor.setHoras(Convert.ToInt32(Console.ReadLine()));

                        //adicionando ao banco de dados
                        metodosProfessor.inserirProfessor(novoProfessor);
                        break;
                    case 2:
                        Console.WriteLine("Digite aqui o código do professor a ser consultado: ");
                        Console.WriteLine(metodosProfessor.consultarProfessor(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 3:
                        Console.WriteLine("Digite aqui o código do professor a ser removido do sistema: ");
                        //Console.WriteLine(metodosProfessor.ExcluirProfessor(Convert.ToInt32(Console.ReadLine())));
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(metodosProfessor.ExcluirProfessor(codigo));
                        break;
                    case 5:
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Essa opção não existe.");
                        break;
                }
            }



        }
    }
}
