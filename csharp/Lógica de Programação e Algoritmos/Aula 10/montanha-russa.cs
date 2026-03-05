using static System.Console;

// Declaração de variáveis
int visitantes =0, contagem = 0;
double alturaMax = 0, alturaMin = 0, alturas = 0;
// Entrada de dados
Write("Digite o número de visitantes: ")
visitantes = int.Parse(ReadLine());
Write("Digite a altura mínima: ")
alturaMin = int.Parse(ReadLine());
Write("Digite a altura máxima: ")
alturaMax = int.Parse(ReadLine());
//Processamento de dados
for(int i = 0; i<visitantes; i++)
{
    Write($"Digite a altura da pessoa nº {i+1}: ")
    alturas = int.Parse(ReadLine());
    if ((alturas >= alturaMin) && (alturas <= alturaMax))
    {
        contagem++;
    }
    WriteLine($"O número de pessoas que podem andar na montanha-russa é: {contagem}");
}
catch (Exception ex)
{
    WriteLine($"Valor inválido, erro: {ex.Message}");
}