//Tipo de variaveis e saida de dados
string nome; //Criando a variavel
nome = "Maria";
char letra; //Caractere
letra = 'A';
double numero;  //Numero decimal com casas decimais
numero = 3.14159;
int numeroInt;  //Numero inteiro
numeroInt = 42;
float numeroFloat;  //Numero decimal
numeroFloat = 2.5f;
bool booleano;  //Booleano, verdadeiro ou falso
booleano = true;

Console.Write(nome); //Sem quebra de linha
Console.Write(nome);
System.Console.WriteLine(nome); //Com snipptes
string pessoa;
pessoa = "Clodoaldo";
Console.WriteLine(pessoa);
const string ESCOLA = "Senai Americana"; //Constante
System.Console.WriteLine(ESCOLA);
Console.WriteLine("O nome do usuário é: " + nome); //Concatenação
Console.WriteLine($"O nome da escola é: {ESCOLA}"); //Interpolação
System.Console.WriteLine("João" + " " + "Couto"); //Concatenação            
Console.WriteLine("O nome do usuário é: {0}", nome); //Formatação
Console.WriteLine("O nome do usuário é: {0}", nome); //Formatação
string joaoVictorCouto; //camelCase