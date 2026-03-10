using static System.Console;
using static System.Linq.Enumerable;
List<string> nomes = new List<string>();
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Ana");
nomes.Add("Lucas");
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Ana");
nomes.Add("Lucas");
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Ana");
nomes.Add("Lucas");
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Ana");
nomes.Add("Lucas");
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Ana");
nomes.Add("Lucas");
nomes.Add("João");
nomes.Add("Maria");
nomes.Add("Pedro");
nomes.Add("Ana");
nomes.Add("Lucas");
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}
System.Console.WriteLine("------------------------------------------------");
nomes = nomes.Distinct().ToList();
foreach (var item in Range(0, nomes.Count))
{
    WriteLine(nomes[item]);
}