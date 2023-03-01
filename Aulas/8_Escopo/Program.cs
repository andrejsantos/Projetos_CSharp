Console.WriteLine("Só entra quem é de maior");
Console.WriteLine();
int idade = 8;
int acompanhado = 0;

bool acompanha = acompanhado > 1;

string textoadicional;

if (acompanha == true)
{
     textoadicional = "André está acompanhado";
}
else
{
     textoadicional = "André não está acompanhado";
}
    


Console.WriteLine("Sua idade é: " + idade);
if (idade >= 18 || acompanha)
{
    Console.WriteLine(textoadicional);
    Console.WriteLine("Está liberado meu filho!");
}

else
{
    Console.WriteLine(textoadicional);
    Console.WriteLine("Nem vem que não tem!!");
}
