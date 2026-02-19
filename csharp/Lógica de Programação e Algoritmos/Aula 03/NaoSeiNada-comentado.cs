double x, y, media;
Console.WriteLine("Digite o primeiro número:");
x=double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
y=double.Parse(Console.ReadLine());
media=(x+y)/2.0;
Console.WriteLine("A média é: " + media);

//
//double x, y, media; 
// Declara três variáveis do tipo double (números decimais): x, y e media.
//Console.WriteLine("Digite o primeiro número:"); 
// Exibe na tela a mensagem pedindo para o usuário digitar o primeiro número.
//x = double.Parse(Console.ReadLine()); 
// Lê o valor digitado pelo usuário (como texto), converte para double e armazena na variável x.
//Console.WriteLine("Digite o segundo número:"); 
// Exibe na tela a mensagem pedindo para o usuário digitar o segundo número.
//y = double.Parse(Console.ReadLine()); 
// Lê o valor digitado pelo usuário (como texto), converte para double e armazena na variável y.
//media = (x + y) / 2.0; 
// Soma os valores de x e y e divide por 2.0 para calcular a média aritmética.
// O 2.0 garante que a divisão seja feita com número decimal.
//Console.WriteLine("A média é: " + media); 
// Double define o tipo das variáveis x, y e media, permitindo armazenar números decimais.
//