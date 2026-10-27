
// Exercícios Fundamentais

// 1.Exibir uma Mensagem
// Escreva um programa que use o comando `Console.WriteLine()` para exibir a frase "Olá, Mundo!" no console.

Console.WriteLine("Olá mundo!");

// 2.Declarar e Usar uma Variável
// Crie um programa que declare uma variável inteira chamada `numero` com o valor 10. 
// Em seguida, imprima o valor dessa variável no console.

int numero = 10;
Console.WriteLine(numero);

// 3. Fazer uma Soma
// Escreva um programa que declare duas variáveis inteiras, `a = 5` e `b = 3`. Calcule a soma das duas e imprima o resultado.

Console.Write("Digite o primeiro número: ");
int numero01 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int numero02 = int.Parse(Console.ReadLine());

int soma = numero01 + numero02;

Console.WriteLine($"{numero01} + {numero02} = {soma}");

// 4.Produto de dois números

// Declare duas variáveis, `num1 = 8` e `num2 = 7`. Calcule o produto (multiplicação) entre elas e imprima o resultado.

int num1 = 8;
int num2 = 7;

int produto = 8 * 7;

Console.WriteLine($"{num1} * {num2} = {produto}");

// Exercícios Intermediários
// 5. Saudação Personalizada

// Crie um programa que declare uma variável `String` chamada `nome` com o valor `"Ana"`. 
// Depois, exiba uma mensagem de boas-vindas, como `"Olá, Ana!"`.

string nome = "Ana";
Console.WriteLine($"Olá, {nome}!");

// 6. Calcular o Dobro

// Declare uma variável inteira valor. Em seguida, calcule o dobro desse número utilizando a variável e exiba o resultado.

int valor = 10;

int dobro = valor * 2;

Console.WriteLine(dobro);

// 7. Média de três números

// Escreva um programa que recebe três números e imprime a média aritmética deles.

Console.Write("Digite o primeiro número: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
double n3 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3) / 3;

Console.WriteLine($"A média é: {media}");

// 8. Ficha de Cadastro

// Peça ao usuário que digite, um de cada vez, o seu nome, a sua idade e a sua cidade. 
// Depois, monte uma única frase com as três informações.

Console.Write("Informe o seu nome: ");
var nome_informado = Console.ReadLine();

Console.Write("Informe a sua idade: ");
var idade_informada = Console.ReadLine();

Console.Write("Informe a sua cidade: ");
var cidade_informada = Console.ReadLine();

Console.WriteLine($"{nome_informado} tem {idade_informada} anos e mora em {cidade_informada}.");

// !. Peça ao usuário para digitar a temperatura atual em graus celsius. O programa deve usar um operador de comparação para
// verificar se a temperatura é menor que 30 e imprimir o resultado (true ou false).

Console.Write("Informe a temperatura: ");
var temperatura = double.Parse(Console.ReadLine());

bool avaliacao = temperatura < 30;

Console.WriteLine($"A temperatura é menor que 30°C?: {avaliacao}");

// Exercícios Avançados

// 9. Verificação de Idade para Votar

// Peça ao usuário para digitar sua idade. O programa deve usar um operador de comparação para verificar 
// se a idade é maior ou igual a 16 e imprimir o resultado (`true` ou `false`).

Console.Write("Informe a sua idade: ");
var idade_inf = double.Parse(Console.ReadLine());

bool pode_votar = idade_inf >= 16;

Console.WriteLine($"O usuário pode votar?: {pode_votar}");

// 10.Usando o Operador Lógico "E" (&&)

// Declare uma variável `int temperatura = 28`. Escreva uma expressão lógica que verifique se a `temperatura` 
// é maior que 25 E menor que 30. Imprima o resultado (`true` ou `false`) no console.

int temperatura01 = 28;

bool resultado = temperatura01 > 25 && temperatura01 < 30;

Console.WriteLine($"A temperatura é maior que 25 e menor que 30?: {resultado}");

// 11.Usando o Operador Lógico "OU" (||)**

// Declare uma variável booleana `temCartao = true` e uma variável `double compra = 50.0`. 
// O cliente ganha um desconto se `temCartao` for verdadeiro OU se o valor da compra for maior que 100.0. 
// Escreva a expressão lógica e imprima o resultado (`true` ou `false`).

bool tem_cartao = true;
double compra = 50.0;

bool ganha_desconto = tem_cartao == true || compra > 50;

Console.WriteLine($"O usuário vai ganhar desconto?: {ganha_desconto}");

// Console.WriteLine = cw + tab/enter

// !. Média de cinco notas

Console.Write("Digite a primeira nota: ");
double n01 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double n02 = double.Parse(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double n03 = double.Parse(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
double n04 = double.Parse(Console.ReadLine());

Console.Write("Digite a quinta nota: ");
double n05 = double.Parse(Console.ReadLine());

double media01 = (n01 + n02 + n03 + n04 + n05) / 5;
double media_arredondada = Math.Round((n01 + n02 + n03 + n04 + n05) / 5, 2);

Console.WriteLine($"A média das notas é: {media01.ToString("F2")}");
Console.WriteLine($"A média das notas é: {Math.Round(media01)}");
Console.WriteLine($"A média das notas é: {media01:F2}");

