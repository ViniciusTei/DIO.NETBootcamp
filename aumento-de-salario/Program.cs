using System;

namespace aumento_de_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario , reajuste , novoSalario, percentual ;

            string usuario = Console.ReadLine();

            if(usuario.Contains(".")) {
                usuario = usuario.Replace(".", ",");
            }

            salario = Convert.ToDouble(usuario);

            if(salario > 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                percentual = 15.00;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = 12.00;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = 10.00;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = 7.00;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if(salario > 2000.00)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = 4.00;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            } else {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = 0.00;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
        }
    }
}
