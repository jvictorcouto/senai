# Explicação do código `fila-parque.cs`

O programa lê alturas de um arquivo CSV, verifica quem está entre 1,5 m e 2,0 m e conta quantos **podem** e quantos **não podem** andar na montanha-russa.

---

## Linhas 1–13: Comentários

Tudo que começa com `//` é **comentário**: o C# ignora. Só descreve a história do parque e do programa. Não altera o comportamento.

---

## Linha 14: `using static System.Console;`

| Parte | Significado |
|-------|-------------|
| `using` | "Use isso no código" |
| `Console` | Parte do C# que escreve na tela e lê do teclado |
| Efeito | Permite usar `WriteLine` sem escrever `Console.` na frente |

---

## Linha 15: `using System.Globalization;`

Dá acesso a `CultureInfo`, `NumberStyles` etc., usados para interpretar números (vírgula ou ponto como decimal).

---

## Linhas 17–19: Regras de altura

```csharp
const double MIN_ALTURA = 1.5;
const double MAX_ALTURA = 2.0;
```

| Termo | Significado |
|-------|-------------|
| `const` | Valor fixo, não muda |
| `double` | Número com casas decimais (ex.: 1,5 e 2,0) |
| `MIN_ALTURA = 1.5` | Altura mínima em metros para poder andar |
| `MAX_ALTURA = 2.0` | Altura máxima em metros |

Quem tem altura **entre 1,5 m e 2,0 m** pode; fora disso não pode.

---

## Linha 21: Comentário da entrada de dados

```csharp
// Entrada de dados: ler do arquivo altura.csv
```

Só descreve: a partir daqui o programa obtém os dados do arquivo `altura.csv`. O comentário em si não é executado.

---

## Linha 22: Onde está o arquivo?

```csharp
string caminhoCsv = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "altura.csv");
```

| Parte | Significado |
|-------|-------------|
| `string` | Tipo que guarda texto |
| `caminhoCsv` | Variável que guarda o caminho (endereço) do arquivo |
| `Path.Combine(...)` | Junta partes de caminho (pastas + nome do arquivo) |
| `AppContext.BaseDirectory` | Pasta de onde o programa está rodando |
| `".."` | "Pasta acima" (três vezes = sobe 3 níveis) |
| `"altura.csv"` | Nome do arquivo |

Resultado: algo como `C:\...\alguma pasta\altura.csv`. É a **primeira tentativa** de localizar o arquivo.

---

## Linhas 23–26: E se o arquivo não existir?

```csharp
if (!File.Exists(caminhoCsv))
    caminhoCsv = Path.Combine(Directory.GetCurrentDirectory(), "altura.csv");
if (!File.Exists(caminhoCsv))
    caminhoCsv = "altura.csv";
```

| Parte | Significado |
|-------|-------------|
| `File.Exists(caminhoCsv)` | "Existe um arquivo nesse caminho?" |
| `!` | Negação ("não") |
| `if (!File.Exists(...))` | "Se o arquivo **não** existir nesse caminho..." |
| `Directory.GetCurrentDirectory()` | Pasta de onde você executou o programa |

O programa tenta até 3 lugares para achar o `altura.csv`.

---

## Linha 28: Ler o arquivo inteiro

```csharp
string[] linhas = File.ReadAllLines(caminhoCsv);
```

| Parte | Significado |
|-------|-------------|
| `string[]` | Lista (vetor) de textos; cada elemento = uma linha |
| `linhas` | Nome da variável |
| `File.ReadAllLines(caminhoCsv)` | Abre o arquivo e devolve todas as linhas em um vetor |

Exemplo: `linhas[0]` = `"altura"`, `linhas[1]` = `"1,35"`, etc.

---

## Linhas 30–31: Contadores

```csharp
int podem_andar = 0;
int nao_podem = 0;
```

| Variável | Significado |
|----------|-------------|
| `podem_andar` | Quantidade de pessoas que **podem** andar (começa em 0) |
| `nao_podem` | Quantidade de pessoas que **não podem** (começa em 0) |

O programa incrementa esses valores ao processar cada altura.

---

## Linhas 34–43: O loop (para cada linha do CSV)

```csharp
for (int i = 1; i < linhas.Length; i++)
{
    ...
}
```

| Parte | Significado |
|-------|-------------|
| `for` | "Repita o bloco várias vezes" |
| `int i = 1` | Começa na linha 1 (pula a linha 0, o cabeçalho "altura") |
| `i < linhas.Length` | Enquanto `i` for menor que a quantidade de linhas |
| `i++` | A cada volta, soma 1 em `i` (próxima linha) |

Ou seja: para **cada linha** do arquivo (exceto a primeira), o programa executa o que está dentro do `{ }`.

---

### Dentro do loop

#### Linha 35: `string valor = linhas[i].Trim().Trim('"');`

- `linhas[i]` = conteúdo da linha `i` (ex.: `"1,35"` ou `"  \"1,35\"  "`).
- `.Trim()` = remove espaços no início e no fim.
- `.Trim('"')` = remove aspas `"` no início e no fim.
- `valor` = texto limpo (ex.: `"1,35"`).

#### Linha 36: `if (string.IsNullOrWhiteSpace(valor)) continue;`

- `string.IsNullOrWhiteSpace(valor)` = "Está vazio ou só espaço?"
- `continue` = pula o resto do loop e vai para a **próxima** linha.

Se a linha estiver vazia, o programa ignora e não conta como pessoa.

#### Linha 37: `if (!double.TryParse(valor.Replace(',', '.'), ... out double metros)) continue;`

- `valor.Replace(',', '.')` = troca vírgula por ponto (ex.: `"1,35"` → `"1.35"`) para o C# interpretar como número.
- `double.TryParse(...)` = tenta converter o texto em número decimal. Se conseguir, coloca em `metros` e retorna `true`; senão, `false`.
- `!` = "não". Se **não** conseguir converter, `continue` = pula a linha.

Só seguimos se `metros` for um número válido (altura em metros).

#### Linhas 39–42: Contar quem pode e quem não pode

```csharp
if (metros >= MIN_ALTURA && metros <= MAX_ALTURA)
    podem_andar++;
else
    nao_podem++;
```

| Parte | Significado |
|-------|-------------|
| `metros >= 1.5` | "Altura é maior ou igual a 1,5?" |
| `&&` | "E" (as duas condições precisam ser verdadeiras) |
| `metros <= 2.0` | "Altura é menor ou igual a 2,0?" |
| `podem_andar++` | Soma 1 em "podem andar" |
| `else` | Caso contrário (fora da faixa) |
| `nao_podem++` | Soma 1 em "não podem" |

---

## Linhas 45–46: Exibir o resultado

```csharp
WriteLine($"Podem acessar o brinquedo: {podem_andar}");
WriteLine($"Não podem acessar o brinquedo: {nao_podem}");
```

| Parte | Significado |
|-------|-------------|
| `WriteLine` | Escreve uma linha na tela |
| `$"..."` | String interpolada: o que está em `{ }` é substituído pelo valor da variável |
| `{podem_andar}` | Número de quem pode |
| `{nao_podem}` | Número de quem não pode |

Exemplo de saída:

```
Podem acessar o brinquedo: 51
Não podem acessar o brinquedo: 120
```

---

## Resumo em uma frase

O programa **localiza o arquivo `altura.csv`**, **lê todas as linhas** (cada uma = uma altura), **conta** quantas pessoas estão entre 1,5 m e 2,0 m (**podem**) e quantas estão fora (**não podem**), e **imprime** essas duas contagens na tela.
