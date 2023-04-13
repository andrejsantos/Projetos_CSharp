using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public double Salario { get; set; }


        public virtual double Getbonificacao() //Virtual = Pode ser reescrito por herança
        {
         
            return this.Salario * 0.10;
        }

    }
}
