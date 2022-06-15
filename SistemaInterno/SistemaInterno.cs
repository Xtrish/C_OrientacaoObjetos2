using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
       public bool Logar(Autenticavel funcionario, string senha,string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login,senha);
            if (usuarioAutenticado== true)
            {
                Console.WriteLine("Bem Vindo ao Sistema, "+funcionario.Nome);
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }

        public bool Logar(GerenteDeContas funcionario, string senha,string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login,senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem Vindo ao Sistema, "+funcionario.Nome);
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }
}
