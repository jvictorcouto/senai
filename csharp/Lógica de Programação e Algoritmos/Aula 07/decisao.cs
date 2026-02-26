double resultado = 10;
// Entrada de dados
System.Console.WriteLine("Digite o numerado para realiazar a divisão:");
double entrada = double.Parse(System.Console.ReadLine() ?? "0");
// Processamento de dados
if (entrada > 0)
{  
    resultado = 2 / entrada;
}
else if (entrada == 0)
{
    resultado = 2 - entrada;
}
else
{
    resultado = 2 + entrada;
}
// Saída de dados
System.Console.WriteLine("O resultado da operação é: " + resultado);