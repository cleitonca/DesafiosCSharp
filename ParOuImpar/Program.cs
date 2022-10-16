
Console.WriteLine("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int resto = numero % 2;

if (resto == 1)
{
    Console.WriteLine("O número informado é impar!");
}
else
    Console.WriteLine("O número informado é par!");

Console.ReadKey();