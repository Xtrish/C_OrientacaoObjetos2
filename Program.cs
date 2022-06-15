
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Ultilitatio;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");


CalcularBonificacao();
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


