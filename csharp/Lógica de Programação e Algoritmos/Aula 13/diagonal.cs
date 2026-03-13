// Fazer um aplicativo de console que leia um número inteiro N (>0 <10)
// e uma matriz quadrada de inteiros de ordem N contendo números inteiros
//em seguida mostrar diagonal principal e a quantidade de valores negativos
// da matriz.
// Exemplo:
// Qual a ordem da matriz: 2
// elemento [0,0]: 5
// elemento [0,1]: -2
// elemento [1,0]: 3
// elemento [1,1]: -1
// Diagonal principal: 5 -1
// Quantidade de valores negativos: 2
// Declaração de uma matriz nxn
using static System.Console;

Write("Qual a ordem da matriz: ");
int n = int.Parse(ReadLine());
if (n <= 0 || n >= 10)
{
    WriteLine("N deve ser maior que 0 e menor que 10.");
    return;
}

int[,] matriz = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Write($"elemento [{i},{j}]: ");
        matriz[i, j] = int.Parse(ReadLine());
    }
}

Write("Diagonal principal: ");
for (int i = 0; i < n; i++)
    Write($"{matriz[i, i]} ");
WriteLine();

int negativos = 0;
for (int i = 0; i < n; i++)
    for (int j = 0; j < n; j++)
        if (matriz[i, j] < 0) negativos++;
WriteLine($"Quantidade de valores negativos: {negativos}");