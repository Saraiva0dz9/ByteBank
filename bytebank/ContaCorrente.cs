using System;
using System.Collections.Generic;
using System.Linq;
 
namespace bytebank
{
    public class ContaCorrente
    {
        public int numeroAgencia;
        public string conta;
        public string titular;
        public double saldo;

        public static void Menu()
        {
            ContaCorrente contaDoLeonardo = new ContaCorrente
            {
                titular = "Leonardo Saraiva",
                numeroAgencia = 09,
                conta = "1010-x",
                saldo = 100
            };

            Console.WriteLine($"Titular da conta: {contaDoLeonardo.titular}");
            Console.WriteLine($"Número da conta: {contaDoLeonardo.conta}");
            Console.WriteLine($"Agência: {contaDoLeonardo.numeroAgencia}");
            Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoLeonardo.saldo)}");

            Console.ReadKey();
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
