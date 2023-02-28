
//Quantidade de amarzenamento
int meuint = 10; //Amarzena de -2,147,483,648 A 2,147,483,647
short meushot = 25;//Amarzena de -32.768 A 32.767
long meulong;//Amarzena de -922337203685477508 A 922337203685477507

double salario = 3000.15;

int salarioint;

salarioint = (int)salario;//Convertendo o double em int
Console.WriteLine(salarioint);//3000

float altura = 1.62f; //Indicando que o 1.62 é float e não double
Console.WriteLine(altura);

Console.WriteLine("Enter = X");
Console.ReadLine();