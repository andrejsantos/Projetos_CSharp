double fatorRendimento = 1.005;
double investimento = 1000;
int mes = 1;
for (int anos = 1; anos <= 5; anos++)
{
    for (mes = 1; mes <= 12; mes++)
    {
        investimento *= fatorRendimento;
    }

    fatorRendimento += 0.001;
}
Console.WriteLine("Depois de 5 anos Você terá R$: " + investimento);
Console.ReadLine();