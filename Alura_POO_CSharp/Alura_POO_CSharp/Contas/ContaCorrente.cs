using Bank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo;
        public Cliente titular; // Colocando referencia da outra classe na mesma /*Usando o NameSpace para pegar a classe*/

        public void Depositar(double valor)// Definindo um metodo publico
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo > valor)
            {
                saldo -= valor;
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
