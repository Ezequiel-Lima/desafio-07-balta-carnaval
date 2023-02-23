using Desafio;

Console.WriteLine("Digite o número de Iterações");
int iteracoes = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] fibonacci = Fibonacci.Sequencia(iteracoes);
for (int i = 0; i < iteracoes; i++)
{
    Console.WriteLine(string.Join(" ", fibonacci.Take(i + 1)));
}