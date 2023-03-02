
for (int contatorlinha = 0; contatorlinha <= 10; contatorlinha++)
{
    for (int contadorcolunas = 0; contadorcolunas <= 10; contadorcolunas++)
    {
        Console.Write("*");
        if (contadorcolunas >= contatorlinha)
        {
            break;//Utilizando Brack para parar o codigo e pular linha
        }
    }
    Console.WriteLine();
}
Console.ReadLine();
