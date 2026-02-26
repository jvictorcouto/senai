using static System.Console;

const int IdadeMinima = 18;

WriteLine("Digite a sua data de nascimento (DDMMYYYY):");

if (!TryParseDataNascimento(ReadLine(), out DateTime dataNascimento))
{
    WriteLine("Data inválida. Use o formato DDMMYYYY, por exemplo: 18061997, sem barras ou espaços.");
    return;
}

int idade = CalcularIdade(dataNascimento);
WriteLine(idade >= IdadeMinima
    ? "Você tem idade suficiente para acessar todos os jogos. Divirta-se!"
    : "Você é menor de idade. Alguns jogos podem não ser adequados para você.");

static bool TryParseDataNascimento(string? entrada, out DateTime data)
{
    data = default;
    if (string.IsNullOrWhiteSpace(entrada) || entrada.Length != 8)
        return false;

    if (!int.TryParse(entrada.AsSpan(0, 2), out int dia) ||
        !int.TryParse(entrada.AsSpan(2, 2), out int mes) ||
        !int.TryParse(entrada.AsSpan(4, 4), out int ano))
        return false;

    try
    {
        data = new DateTime(ano, mes, dia);
        return true;
    }
    catch (ArgumentOutOfRangeException)
    {
        return false;
    }
}

static int CalcularIdade(DateTime dataNascimento)
{
    var hoje = DateTime.Today;
    int idade = hoje.Year - dataNascimento.Year;
    if (hoje < dataNascimento.AddYears(idade))
        idade--;
    return idade;
}