using Bank.Contas; // NameSpaces
using Bank.Titular;// Chamando classe

//ContaCorrente contadoAndré = new ContaCorrente(); //Criando objeto
//contadoAndré.titular = "André de J. Santos";//Campos do objetos - (Publicos)
//contadoAndré.numero_agencia = 15;
//contadoAndré.conta = "1010-X";
//contadoAndré.saldo = 100;

//ContaCorrente contaFernanda = new ContaCorrente();
//contaFernanda.titular = "Fernanda Kelly";
//contaFernanda.numero_agencia = 15;
//contaFernanda.conta = "1011-X";
//contaFernanda.saldo = 500;

//// --------------- Conta André -----------
//Console.WriteLine("--------------------------------------");
//Console.WriteLine($"Titular:{contadoAndré.titular}");
//Console.WriteLine($"Agencia:{contadoAndré.numero_agencia}");
//Console.WriteLine($"Numero da conta:{contadoAndré.conta}");
//Console.WriteLine($"Saldo atual:{contadoAndré.saldo}");
//Console.WriteLine("--------------------------------------");
//Console.WriteLine($"Depositando R$:{100:0.00}");
//contadoAndré.Depositar(100);

//Console.WriteLine($"Saldo atual R$:{contadoAndré.saldo:0.00}");//Formatando os numeros

//Console.WriteLine($"Sacando R$:{300:0.00}");
//contadoAndré.Sacar(300);

//Console.WriteLine($"Saldo atual R$:{contadoAndré.saldo:0.00} ");

//// ------------ Conta Fernanda ----------
//Console.WriteLine("--------------------------------------");
//Console.WriteLine($"Titular:{contaFernanda.titular}");
//Console.WriteLine($"Agencia:{contaFernanda.numero_agencia}");
//Console.WriteLine($"Numero da conta:{contaFernanda.conta}");
//Console.WriteLine($"Saldo atual:{contaFernanda.saldo}");
//Console.WriteLine("--------------------------------------");
//Console.WriteLine($"Trasferindo R$:{250:0.00} ");
//contaFernanda.transferir(250, contadoAndré);

//Console.WriteLine($"Saldo atual R$:{contaFernanda.saldo:0.00}");

//Console.WriteLine("--------------------------------------");

//Console.WriteLine($"Saldo atual 'André' R$:{contadoAndré.saldo:0.00}");
//Console.ReadLine();


//Cliente cliente = new Cliente();
//cliente.nome = "André de J. Santos";
//cliente.cpf = "1234567-89";
//cliente.profissao = "Analista de sistemas";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 1;
//conta.saldo = 100;

//Console.WriteLine($"Titular: {conta.titular.nome}");//Navegando entre objetos
//Console.WriteLine($"CPF: {conta.titular.cpf}");
//Console.WriteLine($"Profissão: {conta.titular.profissao}");
//Console.WriteLine($"N° Conta: {conta.conta}");
//Console.WriteLine($"N° Agencia: {conta.numero_agencia}");
//Console.WriteLine($"Saldo: {conta.saldo}");

ContaCorrente conta3 = new ContaCorrente();
conta3.Conta = "1011-H";
conta3.Numero_agencia = 18;
conta3.DefinirSaldo(-10);
Console.WriteLine(conta3.ObterSaldo()); //Checando Saldo 
Console.WriteLine(conta3.Numero_agencia);
