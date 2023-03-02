using Bank;// Chamando classe

ContaCorrente contadoAndré = new ContaCorrente(); //Criando objeto
contadoAndré.titular = "André de Jesus";
contadoAndré.numero_agencia = 15;
contadoAndré.conta = "1010-X";
contadoAndré.saldo = 100;

Console.WriteLine("Seu saldo é de R$: " + contadoAndré.saldo);
Console.ReadLine();
