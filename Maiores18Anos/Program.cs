
//Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

int idade;

int quantidade = 0;

int contador = 0;

while (contador < 10)
{
    contador++;

    Console.WriteLine("Digte a idade da pessoa: ");
    idade = Convert.ToInt32(Console.ReadLine());

    if(idade >= 15 )
    {
        quantidade += 1;
    }

}

if (quantidade > 0)
    Console.WriteLine($"{quantidade} pessoas é/são maior(es) de 18 anos.");
else
    Console.WriteLine("Nenhuma pessoa é maior de 18 anos");
