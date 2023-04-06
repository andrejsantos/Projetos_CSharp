using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Funcionarios
{
    public class Diretor:Funcionario //Erdando A classe Diretor em Funcionarios
    {

        public double Getbonificacao()
        {
            return this.Salario;
        }
    }
}
