﻿Console.WriteLine("Calculando poupaça");

double investimento = 1000;

//Rendimento de 0.5% (0.005) ao mês
investimento = investimento + investimento * 0.005;
Console.WriteLine(investimento);

int mes = 1;

while (mes <= 12)// Enquanto essa condição for verdadeira continuará executando
{
    investimento = investimento + investimento * 0.005;
    Console.WriteLine("No mês: " + mes + " Você tem R$:" + investimento);

    mes++;
}


Console.ReadLine();
