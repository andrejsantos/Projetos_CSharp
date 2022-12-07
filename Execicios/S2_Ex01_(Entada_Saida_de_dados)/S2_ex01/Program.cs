// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem Vindo ao exercicio 01");
string nome;
int idade;
Console.WriteLine("Digite seu nome: ");//Aqui Lê o que o usuario digita
nome = Console.ReadLine();// Aqui amarzena na variavel 

Console.WriteLine("Digite a sua idade: ");
idade = Convert.ToInt16(Console.ReadLine());// Aqui está convertendo o numero para string para numero

Console.WriteLine(nome + " Você nasceu em: " + (2022 - idade));// Aqui está mostrando o resultado final

Console.ReadKey();