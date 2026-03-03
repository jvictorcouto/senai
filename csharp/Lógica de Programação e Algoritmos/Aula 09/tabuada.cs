using static System.Console;

// Declaração de variáveis
int numero;

// Entrada de dados
WriteLine("Digite um número para ver a tabuada:");
string? entrada = ReadLine();

if (!int.TryParse(entrada, out numero))
{
    WriteLine("Você não digitou um número inteiro válido.");
    return;
}

// Processamento de dados
for (int i = 1; i <= 10; i++)
{
    WriteLine($"{numero} x {i} = {numero * i}");
}