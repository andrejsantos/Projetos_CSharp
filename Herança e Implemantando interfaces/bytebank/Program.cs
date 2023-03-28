using bytebank.Funcionarios;

Funcionario André = new Funcionario();
André.Nome = "André de Jesus Santos";
André.CPF = "390075668-45";
André.Salario = 2000;

Console.WriteLine("----CADASTRO DE FUNCIONARIO---");
Console.WriteLine($"Funcionario: {André.Nome}");
Console.WriteLine($"CPF: {André.CPF}");
Console.WriteLine($"Salario: {André.Salario:00.00}");
Console.WriteLine($"Sua Bonificação é: {André.Getbonificacao()}");

Console.ReadKey();