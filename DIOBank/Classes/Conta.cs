using System;

namespace DIOBank
{
    public class Conta
    {
        private string Nome { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }

        private TipoConta TipoConta { get; set; }

        public Conta(TipoConta tipoConta, 
                    double saldo, 
                    double credito, 
                    string nome) {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        
        public bool Sacar(double valorSaque) 
        {
            if((this.Saldo - valorSaque) < (this.Credito *-1)) 
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }

            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} eh {1}.", this.Nome, this.Saldo);

            return true;
        }

        public void Depositar(double valorDeposito) 
        {
            this.Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} eh {1}.", this.Nome, this.Saldo);
        }

        public void Transferir(double valor, Conta destino)
        {
            if(this.Sacar(valor)) 
            {
                destino.Depositar(valor);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito + " | ";
            return retorno;
        }

        public double GetSaldo() {
            return this.Saldo;
        }

    }
}