Console.WriteLine("Só entra quem é de maior");
Console.WriteLine();
int idade = 8;
int acompanhado = 2;
Console.WriteLine("Sua idade é: " + idade);
if (idade >= 18 || acompanhado > 1)
{
    Console.WriteLine("Está liberado meu filho!");
}

else
{
        Console.WriteLine("Nem vem que não tem!!");
}

/*
 || = OU
 && = E
 
 */

Console.WriteLine();

int mes = 10;

switch (mes) // Um pouco sobre switch
{
    case 1:
        Console.WriteLine("O mês é Janeiro");
        break;
    case 2:
        Console.WriteLine("O mês é Fevereiro");
        break;
    case 3:
        Console.WriteLine("O mês é Março");
        break;
    case 4:
        Console.WriteLine("O mês é Abril");
        break;
    case 5:
        Console.WriteLine("O mês é Maio");
        break;
    case 6:
        Console.WriteLine("O mês é Junho");
        break;
    case 7:
        Console.WriteLine("O mês é Julho");
        break;
    case 8:
        Console.WriteLine("O mês é Agosto");
        break;
    case 9:
        Console.WriteLine("O mês é Setembro");
        break;
    case 10:
        Console.WriteLine("O mês é Outubro");
        break;
    case 11:
        Console.WriteLine("O mês é Novembro");
        break;
    case 12:
        Console.WriteLine("O mês é Dezembro");
        break;
    default:
        Console.WriteLine("Mês inválido");
        break;
}
Console.ReadLine();