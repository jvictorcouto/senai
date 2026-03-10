// Faça um programa que leia um número inteiro positivo N (máximo 10) e depois
// leia N números inteiros e armazene em um vetor. Em seguida mostrar somente
// números negativos.

using static System.Console;
// Declaração de variáveis
int n;
// Entrada de dados
bool valido;
do
{
    Write("Quantos números você deseja digitar? ");
    valido = int.TryParse(ReadLine()?.Trim(), out n);
    if (!valido)
    {
        WriteLine("Entrada inválida. Digite um número inteiro. Entre 1 e 10.");
        valido = true;
    }
    else if (n <= 0 || n > 10)
    {
        WriteLine("Digite um número entre 1 e 10.");
        valido = true;
    }
    else
        valido = false;
} while (valido);
// Processamento de dados
int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    bool ok;
    do
    {
        Write($"Digite o {i + 1}º número: ");
        ok = int.TryParse(ReadLine()?.Trim(), out numeros[i]);
        if (!ok)
            WriteLine("Entrada inválida. Digite um número inteiro.");
        else if (numeros[i] < 0)
        {
            WriteLine("Digite um número positivo.");
            ok = false;
        }
    } while (!ok);
}
// Saída de dados
WriteLine("Números negativos:");
foreach (int numero in numeros)
{
    if (numero < 0)
        WriteLine(numero);
}