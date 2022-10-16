
/*
 * Faça um algoritimo que calcule a média de todos os alunos. 
 * O programa deve solicitar a quantidade de alunos e as suas respectivas notas, depois exibir a média de todos os alunos.
 * 
 */
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de alunos ou zero para sair: ");
        int qtdAlunos = int.Parse(Console.ReadLine());

        double nota, soma = 0, media = 0;
        // double[] notas = new double[qtdAlunos];

        for (int i = 0; i < qtdAlunos; i++)
        {
            Console.WriteLine($"Digite a nota do aluno {i + 1}:");
            soma += double.Parse(Console.ReadLine());
            media = soma / qtdAlunos;


        }

        Console.WriteLine($"A média de notas dos {qtdAlunos} alunos é:" + media);

    }
}


