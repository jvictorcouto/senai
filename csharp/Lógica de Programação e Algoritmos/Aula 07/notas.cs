using static System.Console;
using System.Globalization;

var cultura = CultureInfo.GetCultureInfo("pt-BR");

double LerNota(string mensagem)
{
    while (true)
    {
        WriteLine(mensagem);
        if (double.TryParse(ReadLine(), cultura, out double nota) && nota >= 0 && nota <= 100)
            return nota;
        WriteLine("Nota inválida. Digite um valor entre 0 e 100.");
    }
}

double nota1 = LerNota("Digite a nota do primeiro semestre:");
double nota2 = LerNota("Digite a nota do segundo semestre:");
double media = (nota1 + nota2) / 2;
WriteLine("A média das notas é: " + media);
if (media >= 60)
{
    WriteLine("Aprovado com média: " + media);
}
else
{
    WriteLine("Reprovado. Sua média foi: " + media + " e o mínimo para aprovação é 60 pontos.");}