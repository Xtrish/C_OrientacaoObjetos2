using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 – funcionário
        // 1 – diretor
        // 2 – designer
        // N - ... 

        //private int _tipo;
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um funcionario.");
            totalFuncionarios++;
        }


        public abstract void aumentarSalario();
        public abstract double getBonificacao();

        public string Nome { get; set; }

        public string Cpf { get; private set; }

        public double Salario { get; protected set; }

        public static int totalFuncionarios { get; private set; }

    }
}
