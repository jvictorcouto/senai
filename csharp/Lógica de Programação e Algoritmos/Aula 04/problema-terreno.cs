using static System.Console;
//Declaração de variáveis
double largura, comprimento, valormetroquadrado, area, preco;
WriteLine("Digite a largura do terreno:");
largura = double.Parse(ReadLine());
WriteLine("Digite o comprimento do terreno:");
comprimento = double.Parse(ReadLine());
WriteLine("Digite o valor do m2 do terreno:");
valormetroquadrado = double.Parse(ReadLine());
area = largura * comprimento;
preco = area * valormetroquadrado;
WriteLine("A área do terreno é: " + area);
WriteLine("O preço do terreno é: " + preco);