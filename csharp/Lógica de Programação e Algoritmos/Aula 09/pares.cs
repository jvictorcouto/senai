using static System.Console;
// Declaração de variáveis
int numero, valor;
try{
    //Entrada de dados
    Write("Quantos números você deseja digitar?: ");
    numero = int.Parse(ReadLine() ?? "0");
    // Processamento de dados
    for(int i = 0; i <= numero; i++)
    {
        Write("Digite um número: ");
        valor = int.Parse(ReadLine() ?? "0");
        // Teste de valores, positivo, negativo, par, impar e nulo
        if (valor == 0)
        {
            WriteLine("Nulo ");
        }
        else if (valor < 0)
        {
            WriteLine("Negativo ");
        }
        else
        {
            WriteLine("Positivo ");
        }
        // Par ou ímpar (só importa se não for zero)
        if (valor != 0)
        {
            WriteLine(valor % 2 == 0 ? "Par " : "Impar ");
        }
    }
}
catch(Exception ex){
    WriteLine($"Digite valores válidos, erro: {ex.Message}");
}