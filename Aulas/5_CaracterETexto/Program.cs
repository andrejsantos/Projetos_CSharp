char  letra = 'a'; // char só amarzena um caracter por vez
Console.WriteLine("Mostrando o caracter indicado: " + letra); //a

Console.WriteLine();

letra = (char)65; //Convertendo int em char e atribuindo uma letra atráves do numero
Console.WriteLine("O numero (65) representa: " + letra); // A 

Console.WriteLine();

letra = (char)(65 + 1); // Somando para apresentar outro caracter
Console.WriteLine("Somando + 1 corresponde a: " + letra);

Console.WriteLine();

string frase = "Amarzenando uma frase inteira"; // string amarzena uma frase inteira
Console.WriteLine(frase);

Console.WriteLine();

frase = ""; // Podemos deixar uma string vazia
Console.WriteLine();

string lista = @"Lista de compras:  
- Maçã
- Abacate
- Arroz
- Tomate";
Console.WriteLine(lista);
Console.ReadLine();