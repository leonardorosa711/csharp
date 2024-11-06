// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Concatenção
string nome = "erick";
string saudacao = "Ola," + nome + "! Bem-vindo.";
Console.WriteLine(saudacao);

// Iterpolcao de strings($)
string nome = "erick";
string saudacao = $"Ola, {nome}! Bem-vindo.";
Console.WriteLine(saudacao);

// Operador GetType()
int numero = 5;
Console.WriteLine(numero.GetType());

// Palavra-chave typeof
Console.WriteLine(typeof(int));

// Metodo parse
string valorTexto = "100";
Console.WriteLineparse("A variavel valorTexto e do tipo: " + valorTexto.GetType());

int numero = int.Parse(valorTexto);
Console.WriteLineparse(numero);
Console.WriteLineparse("A variavel numeroParse e do tipo: " + numero.GetType());

// Cast/Casting (Conversao de um numero do tipo string para int, float ou double usando Convert)
string valorEmTexto = "100";
Console.WriteLine("Valor da variavél String: " + valorEmTexto);
Console.WriteLine("A variável valorTexto é do tipo: " + valorEmTexto.GetType());

int numeroConvertido = numeroConvertido.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("Após conversão a variavél numeroConvertido é do tipo: " + numeroConvertido.GetType());

// Convert Qualquer Tipo para String com ToString()
int numero = 123;
Console.WriteLine(numero.GetType());

string numeroComoString = numero.ToString();
Console.WriteLine(numeroComoString.GetType());

// Personalização de Formatação para data e hora
DataTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string dataFormatada = dataAtual.ToString("HH:mm:ss");
Console.WriteLine(dataHoraFormatada);

// Metodo ToString - Interpolção de string
double preco = 29.99;
Console.WriteLine($"O preço é: {preco.ToString("C2")}");

Console.WriteLine($"O preço é: {preco1.ToString("C2")}");

// Formatacao de acordo com a localizacao (using System.Globalization)
decimal valor = 1234.56m;
string valourUS = valor.ToString("C", new System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
Console.WriteLine(valorBR);
