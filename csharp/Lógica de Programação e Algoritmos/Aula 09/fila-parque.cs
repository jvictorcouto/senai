// Todos os habitantes da LuffyLandia estão super animados com a abertura do 
//Ricardo Barreiro World, o mais novo parque de diversões do país. Na TV e no rádio só 
//passam propagandas da montanha-russa do parque, a mais rápida do continente. 
//É nela que todos, de crianças a idosos querem andar.
// Infelizmente foram impostas algumas restrições no momento da homologação do brinquedo 
// pelo governo. Por questões de segurança, há uma altura mínima e uma altura máxima que as 
// pessoam devem ter para poder passear na montanha-russa.
// Para o dia da inauguração do parque, todos os convidados 
//realizaram um pré-cadastro no qual indicaram sua altura. Para reduzir filas e 
//otimizar a operação do parque no primeiro dia, você foi contratado para fazer um 
//programa que dado o número de visitantes, altura mínima, altura máxima e as alturas de 
//todos os visitantes, calcule quantas pessoas poderão andar na montanha-russa.
//
using static System.Console;
using System.Globalization;

// Declaração de constantes (em metros)
const double MIN_ALTURA = 1.5;
const double MAX_ALTURA = 2.0;

// Entrada de dados: ler do arquivo altura.csv
string caminhoCsv = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "altura.csv");
if (!File.Exists(caminhoCsv))
    caminhoCsv = Path.Combine(Directory.GetCurrentDirectory(), "altura.csv");
if (!File.Exists(caminhoCsv))
    caminhoCsv = "altura.csv";

string[] linhas = File.ReadAllLines(caminhoCsv);

int podem_andar = 0;
int nao_podem = 0;

// Primeira linha é o cabeçalho "altura"
for (int i = 1; i < linhas.Length; i++)
{
    string valor = linhas[i].Trim().Trim('"');
    if (string.IsNullOrWhiteSpace(valor)) continue;
    if (!double.TryParse(valor.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double metros))
        continue;
    if (metros >= MIN_ALTURA && metros <= MAX_ALTURA)
        podem_andar++;
    else
        nao_podem++;
}

WriteLine($"Podem acessar o brinquedo: {podem_andar}");
WriteLine($"Não podem acessar o brinquedo: {nao_podem}");
