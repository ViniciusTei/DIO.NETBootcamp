using System;
using System.Collections.Generic;

namespace DIOBank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
           string opcao = ObterOpcao();

           while(opcao != "X") {
               switch(opcao) {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        //todo transferir
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
               }

               opcao = ObterOpcao();
           }
        }

        private static string ObterOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank - Informe a opcao desejada: ");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");

            string opcao = Console.ReadLine().ToUpper();
            return opcao;
        }

        private static void InserirConta() {
            Console.WriteLine("Digite 1 para Conta Fisica e 2 para Juridica");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do clinete");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o credito");
            double credito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta((TipoConta)tipoConta, saldo, credito, nome);

            listaContas.Add(novaConta);
            Console.WriteLine("Conta adicionada com sucesso!");
        }

        private static void ListarContas() {
            if(listaContas.Count == 0) {
                Console.WriteLine("Lista vazia!");
                return;
            }

            foreach (var conta in listaContas)
            {
                Console.Write("#{0} - ", listaContas.IndexOf(conta));
                Console.WriteLine(conta.ToString());
            }
        }

        private static void Sacar() {
            Console.WriteLine("Digite o numbero da conta:" );
            int index = int.Parse(Console.ReadLine());

            Conta c = listaContas[index];

            Console.WriteLine("Saldo atual: {0}", c.GetSaldo());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valor = double.Parse(Console.ReadLine());

            c.Sacar(valor);

        }

        private static void Depositar() {
            Console.WriteLine("Digite o numbero da conta:" );
            int index = int.Parse(Console.ReadLine());

            Conta c = listaContas[index];

            Console.WriteLine("Saldo atual: {0}", c.GetSaldo());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valor = double.Parse(Console.ReadLine());

            c.Depositar(valor);
        }

        private static void Transferir() {
            Console.WriteLine("Digite o numbero da conta de origem:" );
            int indexOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numbero da conta de destino:" );
            int indexDestino = int.Parse(Console.ReadLine());

            Conta origem = listaContas[indexOrigem];
            Conta destino = listaContas[indexDestino];

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valor = double.Parse(Console.ReadLine());

            origem.Transferir(valor, destino);
        }
    }
}
