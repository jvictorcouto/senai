//Entrada de dados
/*----------------------*/
Console.WriteLine("Digite o seu nome:");
string nome = Console.ReadLine() ?? "";
System.Console.WriteLine($"O nome digitado foi: {nome}");
System.Console.WriteLine("Digite o primeiro número:");
double x = double.Parse(Console.ReadLine() ?? "0");
System.Console.WriteLine("Digite o segundo número:");
double y = double.Parse(Console.ReadLine() ?? "0");
double soma = x + y;
System.Console.WriteLine($"A soma dos números é: {soma}");
/*----------------------*/
//Processamento de dados//
double soma2 = x + y;
/*----------------------*/
//Saída de dados//
System.Console.WriteLine($"A soma dos números é: {soma}");