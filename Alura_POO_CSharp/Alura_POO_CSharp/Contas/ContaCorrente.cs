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
        private int numero_agencia;
        public int Numero_agencia // Verificando se o numero da agencia está validado
        {
            get { return this.numero_agencia; }// Propriedades
            set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        //private string conta;
        public string Conta { get; set; }
        private double saldo = 100;
        private Cliente titular; // Colocando referencia da outra classe na mesma /*Usando o NameSpace para pegar a classe*/
        public Cliente Titular { get; set; }
        public void Depositar(double valor)// Definindo um metodo publico
        {
            saldo += valor;
        }

        public void Sacar(double valor) // Definindo que o slado não terá numeros negativos
        {
            if (saldo > valor)//Se for menor que 0 ele retornara o valor definido em "saldo"
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
        public void DefinirSaldo(double valor)
        {
            if (valor <= 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double ObterSaldo()
        {
            return this.saldo;
        }
    }
}
