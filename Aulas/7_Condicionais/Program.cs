Console.WriteLine("Só entra quem é de maior");
Console.WriteLine();
int idade = 8;
int acompanhado = 2;
Console.WriteLine("Sua idade é: " + idade);
if (idade >= 18) 
{
    Console.WriteLine("Está liberado meu filho!");
}

else
{
    if (acompanhado > 0) //Se o primeiro if for false ele verifica esse aqui
    {
        Console.WriteLine("Está acompanhado pode entrar!");
    }
    else // Caso os doi if seja false ele para aqui
    {
        Console.WriteLine("Nem vem que não tem!!");
    }
    
}

/*
 || = OU
 && = E
 
 */

Console.ReadLine();