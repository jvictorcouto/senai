/*
    Problema:
    Fazer um aplicativo de console que leia as medidas da base e altura de um retângulo, 
    em seguida, mostrar o valor área, perímetro e diagonal deste retângulo.
*/
using static System.Console;
//Declaração de variáveis
int largura, altura, area, perimetro;
double diagonal;
WriteLine("Digite a base do retângulo:");
largura = (ReadLine() ?? "0");
WriteLine("Digite a altura do retângulo:");
altura = int.Parse(ReadLine() ?? "0");
//---Processamento de dados----
area = largura * altura;
perimetro = 2 * (largura + altura);
diagonal = Math.Sqrt(largura * largura + altura * altura);
//----Saída de dados----    
WriteLine("A área do retângulo é de: " + area);
WriteLine("O perímetro do retângulo é de: " + perimetro);
WriteLine("A diagonal do retângulo é de: " + diagonal);int.Parse