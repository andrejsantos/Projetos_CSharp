using bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Ultilitario
{
    public class Gerenciador_Bonificacao
    {
        public double TotBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotBonificacao += funcionario.Getbonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.TotBonificacao += diretor.Getbonificacao();
        }
    }
}
