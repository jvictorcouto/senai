using static System.Console;
// Declaração de variáveis
const int SENHA = 1234;
int senha;
// Entrada de dados (senha totalmente oculta - nada é exibido ao digitar)
Write("Digite a senha: ");
string senhaDigitada = "";
ConsoleKeyInfo tecla;
do
{
    tecla = ReadKey(intercept: true);
    if (tecla.Key == ConsoleKey.Backspace && senhaDigitada.Length > 0)
    {
        senhaDigitada = senhaDigitada.Remove(senhaDigitada.Length - 1);
    }
    else if (char.IsDigit(tecla.KeyChar))
    {
        senhaDigitada += tecla.KeyChar;
    }
} while (tecla.Key != ConsoleKey.Enter);
WriteLine();
senha = string.IsNullOrEmpty(senhaDigitada) ? 0 : int.Parse(senhaDigitada);
// Processamento de dados
if (senha == SENHA)
{
    WriteLine("Senha correta");
}
else
{
    WriteLine("Senha incorreta");
}
