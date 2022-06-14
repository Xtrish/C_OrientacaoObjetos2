
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Ultilitatio;

Console.WriteLine("Boas Vindas, ao ByteBank Administração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "123456789-7";
pedro.Salario = 2000;

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "8142121";
paula.Salario = 5000;

Funcionario andre = new Diretor();
andre.Nome = "André";

Console.WriteLine("Bonificação: "+paula.getBonificacao());
Console.WriteLine("Bonificação: " + pedro.getBonificacao());



gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);
Console.WriteLine("Total de bonificacao: " + gerenciador.getBonificacao());

Console.ReadKey();



