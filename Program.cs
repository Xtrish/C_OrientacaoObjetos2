
using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Ultilitatio;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");


//CalcularBonificacao();

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("456.854.655-89");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("654.759.315.73");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("258+963.741-65");
    paula.Nome = "Paula";


    Auxiliar igor = new Auxiliar("789.753.951-30");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("159.753.654-15");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());





    Console.ReadKey();
}

void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new Diretor("988.684.625-55");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";
    roberta.Login = "roberta@gmail.com";

    GerenteDeContas ursula = new GerenteDeContas("154.785.888-96");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";
    ursula.Login = "ursula1925@cade.com";

    Funcionario pedro =  new  Designer("7854.965.032-32");
    pedro.Nome = "Pedro";
 

    sistemainterno.Logar(roberta, roberta.Senha,roberta.Login);
    sistemainterno.Logar(ursula, ursula.Senha,ursula.Login);

}

SistemaInterno sistemaInterno = new SistemaInterno();



Diretor bernardo = new Diretor("159.635.398-04");
bernardo.Nome = "Bernardo";
bernardo.Login = "bernardo@email.com";
bernardo.Senha = "flaflu2019";

sistemaInterno.Logar(bernardo, bernardo.Senha, bernardo.Login);


Console.ReadKey();


