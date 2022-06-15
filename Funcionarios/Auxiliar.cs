using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando um Auxiliar." + Nome);


        }
        public override double getBonificacao()
        {
            return Salario *= 1.20;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 0.10;
        }
    }
}
