using static System.Console;

static void Total(int qtd, double valor)
{
    WriteLine($"Total: {qtd * valor}");
}
// Declaração de variáveis
int codigo, quantidade;
// Entrada de dados
try{
    WriteLine("Digite o código do produto:");
    codigo = int.Parse(ReadLine() ?? "0");
    WriteLine("Digite a quantidade do produto:");
    quantidade = int.Parse(ReadLine() ?? "0");
    switch(codigo)
    {
        case 1:
            Total(quantidade, 10.0);
            break;
        case 2:
            Total(quantidade, 15.0);
            break;
        default:
            WriteLine("Código do produto não cadastrado");
            break;
    }
}
catch(Exception ex){
    WriteLine($"Digite valores válidos, erro: {ex.Message}");
}