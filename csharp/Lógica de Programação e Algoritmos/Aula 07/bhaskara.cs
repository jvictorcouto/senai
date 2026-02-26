using static System.Console;
double a, b, c, delta, x1, x2;
// Entrada de dados
WriteLine("Digite o valor de a:");
a = double.Parse(ReadLine() ?? "0");
WriteLine("Digite o valor de b:");
b = double.Parse(ReadLine() ?? "0");
WriteLine("Digite o valor de c:");
c = double.Parse(ReadLine() ?? "0");
// Processamento de dados
delta = (b * b) - 4 * a * c;
WriteLine("O valor de delta é: " + delta);
if (delta < 0)
{
    WriteLine("A equação não possui raízes reais.");
}
else if (delta == 0)
{
    x1 = -b / (2 * a);
    x2 = x1;
    WriteLine("A equação possui uma raiz real: " + x1);
    WriteLine("O valor de x1 é: " + x1);
    WriteLine("O valor de x2 é: " + x2);
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    WriteLine("A equação possui duas raízes reais: " + x1 + " e " + x2);
    WriteLine($"x1 = {x1}\nx2 = {x2}");
}
