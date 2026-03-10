using static System.Console;

int n = 0;

do
{
    WriteLine(n);
    n++;
    Task.Delay(1000).Wait();
} while (n < 14);
WriteLine("Fim do loop");

