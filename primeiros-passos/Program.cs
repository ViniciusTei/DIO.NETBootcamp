using System;

namespace primeiros_passos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indexAluno = 0;
            string opcao = ObterOpcaoUsuario();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Irforme a nota do aluno: ");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal.");
                        }         

                        alunos[indexAluno] = aluno;
                        indexAluno++;
                        break;
                    case "2":
                        foreach (var item in alunos)
                        {
                            if (!string.IsNullOrEmpty(item.Nome))
                            {
                                Console.WriteLine($"ALUNO: {item.Nome} - NOTA {item.Nota}");
                                
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        for (int i = 0; i < indexAluno; i++)
                        {
                            notaTotal = notaTotal + alunos[i].Nota;
                        }
                        var media = notaTotal/indexAluno;
                        Console.WriteLine($"MEDIA TOTAL: {media}");
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                }
                Console.WriteLine();
                opcao = ObterOpcaoUsuario();
            }
            
        }
        
        private static string ObterOpcaoUsuario()
        {
            //imprimir menu de opcoes para o usuario
            Console.WriteLine("Informe a opcao desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("-------------------------");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
