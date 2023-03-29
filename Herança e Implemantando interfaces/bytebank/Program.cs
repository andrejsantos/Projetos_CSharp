using bytebank.Funcionarios;
using bytebank.Ultilitario;

Funcionario André = new Funcionario();
André.Nome = "André J.S";
André.CPF = "390075668-45";
André.Salario = 2000;

Console.WriteLine("----CADASTRO DE FUNCIONARIO---");
Console.WriteLine($"Funcionario: {André.Nome}");
Console.WriteLine($"CPF: {André.CPF}");
Console.WriteLine($"Salario: {André.Salario:00.00}");
Console.WriteLine($"Sua Bonificação é: {André.Getbonificacao():0,00.00}");

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

Diretor joao = new Diretor();
joao.Nome = "João C.D";
joao.CPF = "55555555-66";
joao.Salario = 5000;

Console.WriteLine("----CADASTRO DE Diretor---");
Console.WriteLine($"Funcionario: {joao.Nome}");
Console.WriteLine($"CPF: {joao.CPF}");
Console.WriteLine($"Salario: {joao.Salario:0,00.00}");
Console.WriteLine($"Sua Bonificação é: {joao.Getbonificacao():0,00.00}");

Console.WriteLine();
Console.WriteLine("-------------------------");
Console.WriteLine();

Gerenciador_Bonificacao Gerenciador = new Gerenciador_Bonificacao();
Gerenciador.Registrar(André);
Gerenciador.Registrar(joao);

Console.WriteLine($"O Total de bonificação é:{Gerenciador.TotBonificacao:0,00.00}");



Console.ReadKey();