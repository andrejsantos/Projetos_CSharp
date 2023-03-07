using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void Depositar(double valor)// Definindo um metodo publico
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo > valor) {
                this.saldo -= valor;
            }
            else
            {
                Console.WriteLine($"Impossivel sacar, Você só tem R$:{valor:0.00} na conta");
            }
            
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
            
        }
    }
}
