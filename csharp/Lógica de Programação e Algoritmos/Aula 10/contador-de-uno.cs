using static System.Console;

// Controle de fluxo de veículos nas dunas — Cooperativa de Turismo de Barreirinhas

int veiculoDunas = 0;
int qtdVisitantes = 0;

while (true)
{
    Write("Digite E1-E5 (entrando), S1-S5 (saindo) ou fim: ");
    string entrada = ReadLine()?.Trim()?.ToUpperInvariant() ?? "";

    if (entrada == "FIM")
        break;

    if (entrada.Length < 2)
    {
        WriteLine("Entrada inválida. Use E1, E2, ... E5 ou S1, S2, ... S5.");
        continue;
    }

    char direcao = entrada[0];
    bool qtdOk = int.TryParse(entrada.Substring(1), out int qtdVisitantesCarro);

    if ((direcao != 'E' && direcao != 'S') || !qtdOk || qtdVisitantesCarro < 1 || qtdVisitantesCarro > 5)
    {
        WriteLine("Entrada inválida. Use E1 a E5 ou S1 a S5.");
        continue;
    }

    if (direcao == 'S')
    {
        veiculoDunas -= 1;
        qtdVisitantes -= qtdVisitantesCarro;
    }
    else
    {
        veiculoDunas += 1;
        qtdVisitantes += qtdVisitantesCarro;
    }
}

WriteLine($"Veículos no parque: {veiculoDunas}");
WriteLine($"Turistas no parque: {qtdVisitantes}");