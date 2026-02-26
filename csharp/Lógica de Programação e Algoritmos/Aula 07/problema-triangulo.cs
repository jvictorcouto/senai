using static System.Console;

WriteLine("Digite o valor de a:");
double a = double.Parse(ReadLine() ?? "0");
WriteLine("Digite o valor de b:");
double b = double.Parse(ReadLine() ?? "0");
WriteLine("Digite o valor de c:");
double c = double.Parse(ReadLine() ?? "0");

// Condição de existência do triângulo: cada lado menor que a soma dos outros dois
bool formaTriangulo = a < b + c && b < a + c && c < a + b;

if (formaTriangulo)
{
    // Fórmula de Heron: A = √(p.(p-a).(p-b).(p-c))  |  p = (a+b+c)/2
    double p = (a + b + c) / 2;
    double areaHeron = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    WriteLine($"Forma triângulo. Área (Heron): {areaHeron}");
}
else
{
    double areaT = ((a + b) * c) / 2;
    WriteLine($"Não forma triângulo. Área do trapézio: {areaT}");
}