// Declaração de uma matriz 3x3
int [,] matriz = new int [3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($"Digite o valor da posição [{i}, {j}]: ");
        matriz[i, j] = int.Parse(ReadLine());
    }
}
WriteLine("Matriz preenchida: ");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($"{matriz[i, j]} ");
    }
    WriteLine();
}