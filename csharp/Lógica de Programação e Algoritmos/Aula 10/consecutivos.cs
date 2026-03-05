using static System.Console;
// Declaração de variáveis
long x, resultado;
while (true)
{
    Write("Digite um número ou 0 para sair: ");
    if (!long.TryParse(ReadLine(), out x))
    {
        WriteLine("Número inválido. Tente novamente.");
        continue;
    }
    if (x == 0)
    {
        break;
    }
    if ((x % 2) == 0)
    {
        // Numero par
        // Processamento de dados
        WriteLine("Número par");
        resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
    }
    else
    {
        // Numero ímpar
        // Processamento de dados
        x = x + 1;
        resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
        WriteLine($"Número ímpar: {x}");
    }
    WriteLine($"Soma = {resultado}");
}