using static System.Console;
// Declaração de variáveis
const int SENHA = 1234;
int senha, contagem = 0;
// Entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
// Processamento de dados
while (senha != SENHA)
{
    if (contagem >= 3)
    {
        WriteLine("Acesso bloqueado");
        break;
    }
    contagem++;
    WriteLine("Senha Incorreta, tente novamente");
    senha = int.Parse(ReadLine() ?? "0");
}
if (senha == SENHA)
{
    WriteLine($"Senha correta, você tentou {contagem} vezes");
}