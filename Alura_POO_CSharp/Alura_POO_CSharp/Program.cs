using Bank;// Chamando classe

ContaCorrente contadoAndré = new ContaCorrente(); //Criando objeto
contadoAndré.titular = "André de J. Santos";//Campos do objetos - (Publicos)
contadoAndré.numero_agencia = 15;
contadoAndré.conta = "1010-X";
contadoAndré.saldo = 100;

ContaCorrente contaFernanda = new ContaCorrente();
contaFernanda.titular = "Fernanda Kelly";
contaFernanda.numero_agencia = 15;
contaFernanda.conta = "1011-X";
contaFernanda.saldo = 500;

// --------------- Conta André -----------
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Titular:{contadoAndré.titular}");
Console.WriteLine($"Agencia:{contadoAndré.numero_agencia}");
Console.WriteLine($"Numero da conta:{contadoAndré.conta}");
Console.WriteLine($"Saldo atual:{contadoAndré.saldo}");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Depositando R$:{100:0.00}");
contadoAndré.Depositar(100);

Console.WriteLine($"Saldo atual R$:{contadoAndré.saldo:0.00}");//Formatando os numeros

Console.WriteLine($"Sacando R$:{300:0.00}");
contadoAndré.Sacar(300);

Console.WriteLine($"Saldo atual R$:{contadoAndré.saldo:0.00} ");

// ------------ Conta Fernanda ----------
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Titular:{contaFernanda.titular}");
Console.WriteLine($"Agencia:{contaFernanda.numero_agencia}");
Console.WriteLine($"Numero da conta:{contaFernanda.conta}");
Console.WriteLine($"Saldo atual:{contaFernanda.saldo}");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Trasferindo R$:{250:0.00} ");
contaFernanda.transferir(250, contadoAndré);

Console.WriteLine($"Saldo atual R$:{contaFernanda.saldo:0.00}");

Console.WriteLine("--------------------------------------");

Console.WriteLine($"Saldo atual 'André' R$:{contadoAndré.saldo:0.00}");
Console.ReadLine();
