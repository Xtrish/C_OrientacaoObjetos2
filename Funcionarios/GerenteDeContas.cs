using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um Gerente de Contas." + Nome);


        }
        public override double getBonificacao()
        {
            return Salario *= 1.25;
        }
        public override void aumentarSalario()
        {
            this.Salario *= 0.05;
        }
      
    }
}
