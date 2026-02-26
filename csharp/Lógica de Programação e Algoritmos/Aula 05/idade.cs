/*
   Problema:
   Fazer um aplicativo de terminal que leia o valor inteiro
   correspondente a idade de uma pessoa em dias e informe-a em anos, meses e dias.
*/
using static System.Console;
//Declaração de variáveis
int idadeEmDias, anos, meses, dias;
WriteLine("Digite a idade em dias:");
idadeEmDias = int.Parse(ReadLine() ?? "0");
//---Processamento de dados----
anos = idadeEmDias / 365;
meses = (idadeEmDias % 365) / 30;
dias = (idadeEmDias % 365) % 30;
//----Saída de dados----
WriteLine("A idade em anos é de: " + anos);
WriteLine("A idade em meses é de: " + meses);
WriteLine("A idade em dias é de: " + dias);