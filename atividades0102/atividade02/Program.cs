// Nível Fácil

// 1. Dobro de um número
// Leia um número inteiro e mostre o dobro dele.

Console.Write("Informe um número: ");
double numero = double.Parse(Console.ReadLine());

Console.WriteLine($"O dobro de {numero} é {numero * 2}.");

// 2. Soma simples
// Leia dois números e exiba a soma.

Console.Write("Informe o primeiro número: ");
double numero01 = double.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
double numero02 = double.Parse(Console.ReadLine());

double soma = numero01 + numero02;

Console.WriteLine($"{numero01} + {numero02} = {numero01 + numero02}");

// 3. Par ou ímpar
// Leia um número e informe se ele é par ou ímpar.

Console.Write("Informe um número inteiro: ");
int par_impar = int.Parse(Console.ReadLine());

bool avaliacao = par_impar % 2 == 0;

if (avaliacao == true)
{
    Console.WriteLine($"O número {par_impar} é par.");

}
else
{
    Console.WriteLine($"O número {par_impar} é ímpar.");
}

// 4. Maior número
// Leia dois números e informe qual é o maior.

Console.Write("Informe o primeiro número: ");
double numero_informado1 = double.Parse(Console.ReadLine());

Console.Write("Informe o segundo número: ");
double numero_informado2 = double.Parse(Console.ReadLine());

double maior_numero = numero_informado1;

if (maior_numero < numero_informado2)
{
    maior_numero = numero_informado2;
    Console.WriteLine($"O maior número é {maior_numero}.");
}

// 5. Idade mínima
// Leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais).

Console.Write("Informe a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine($"Você é maior de idade! ({idade} anos).");
}
else
{
    Console.WriteLine($"Você é menor de idade! ({idade} anos).");

}

// Nível Médio

// 1. Média de notas
// Leia duas notas e calcule a média.
// Exiba se o aluno foi aprovado (média >= 6).

Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;
Console.WriteLine($"Média: {media}");

if (media >= 6)
{
    Console.WriteLine("Aluno Aprovado!");
}
else
{
    Console.WriteLine("Aluno Reprovado.");
}

// 2. Intervalo numérico
// Leia um número e informe se ele está entre 50 e 100.

Console.Write("Digite un número para verificar o intervalo: ");
int numeroIntervalo = int.Parse(Console.ReadLine());

if (numeroIntervalo >= 50 && numeroIntervalo <= 100)
{
    Console.WriteLine("O número está entre 50 e 100.");
}
else
{
    Console.WriteLine("O número NÃO está entre 50 e 100.");
}

// 3. Desconto em produto
// Leia o valor de um produto.
// Se o valor for maior que 100, aplique 10% de desconto.
// Mostre o valor final.

Console.Write("Digite o valor do produto: R$ ");
double valorProduto = double.Parse(Console.ReadLine());

if (valorProduto > 100)
{
    double desconto = valorProduto * 0.10;
    valorProduto -= desconto; // Aplica os 10% de desconto
}
Console.WriteLine($"Valor final do produto: R$ {valorProduto:F2}");

//// 4. Positivo, negativo ou zero
//// Leia um número e informe se ele é positivo, negativo ou zero.

Console.Write("Digite um número: ");
int numInformado = int.Parse(Console.ReadLine());

if (numInformado > 0)
{
    Console.WriteLine("O número é Positivo.");
}
else if (numInformado < 0)
{
    Console.WriteLine("O número é Negativo.");
}
else
{
    Console.WriteLine("O número é Zero.");
}

// 5. Pode votar
// Leia a idade e informe se a pessoa pode votar (idade >= 16).

Console.Write("Digite a sua idade: ");
int idadeVoto = int.Parse(Console.ReadLine());

if (idadeVoto >= 16)
{
    Console.WriteLine("Você já pode votar!");
}
else
{
    Console.WriteLine("Você ainda não pode votar.");
}

// Nível Difícil

// 1. Sistema de login simples
// Peça um usuário e senha.
// Considere válidos:
//     - usuário: admin
//     - senha: 1234
// Informe se o login foi bem-sucedido.

Console.Write("Usuário: ");
string usuario = Console.ReadLine();
Console.Write("Senha: ");
string senha = Console.ReadLine();

if (usuario == "admin" && senha == "1234")
{
    Console.WriteLine("Login bem-sucedido!");
}
else
{
    Console.WriteLine("Usuário ou senha incorretos.");
}

// 2. Maior de três números
// Leia três números e informe qual é o maior.

Console.Write("\nDigite o primeiro número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
int n3 = int.Parse(Console.ReadLine());

int maior = n1;

if (n2 > maior)
{
    maior = n2;
}
if (n3 > maior)
{
    maior = n3;
}
Console.WriteLine($"O maior número é: {maior}");

// 3. Cálculo de salário com bônus
// Leia o salário de um funcionário.
// Se for maior que 2000, acrescente 10%.
// Caso contrário, acrescente 20%.
// Mostre o novo salário.

Console.Write("\nDigite o salário atual: R$ ");
double salario = double.Parse(Console.ReadLine());

if (salario > 2000)
{
    Console.WriteLine($"Salário acima de R$ 2000,00. Bônus de 10% aplicado. Salário final: R$ {salario * 1.10}");
}
else
{
    Console.WriteLine($"Salário abaixo de R$ 2000,00. Bônus de 20% aplicado. Salário final: R$ {salario * 1.20}");
}

// 4. Ano bissexto (simplificado)
// Leia um ano e informe se ele é divisível por 4 (considere isso como critério).

Console.Write("\nDigite um ano: ");
int ano = int.Parse(Console.ReadLine());

if (ano % 4 == 0)
{
    Console.WriteLine($"O ano de {ano} é bissexto.");
}
else
{
    Console.WriteLine("O ano NÃO é bissexto.");
}

// 5. Validação de acesso
// Leia:
//     - idade
//     - possui convite (true/false)
// A pessoa só pode entrar se:
//     - tiver 18 anos ou mais E
//     - possuir convite
// Mostre se o acesso foi permitido.

Console.Write("\nDigite a idade para o acesso: ");
int idadeAcesso = int.Parse(Console.ReadLine());

Console.Write("Possui convite? (sim/não): ");
string possuiConvite = Console.ReadLine();

if (idadeAcesso >= 18 && possuiConvite == "sim")
{
    Console.WriteLine("Acesso permitido!");
}
else
{
    Console.WriteLine("Acesso negado.");
}

// Exercícios Obrigatórios

// (FGV / TCE - SE) Duas tartarugas estavam juntas e começaram a caminhar em linha reta em direção a um lago distante. 
// A primeira tartaruga percorreu 30 metros por dia e demorou 16 dias para chegar ao lago. 
// A segunda tartaruga só conseguiu percorrer 20 metros por dia e, portanto, chegou ao lago alguns dias depois da primeira. 
// Quando a primeira tartaruga chegou ao lago, o número de dias que ela teve que esperar para a segunda tartaruga chegar foi:

int distancia = 30 * 16;
int dias_segunda = distancia / 20;
int espera = dias_segunda - 16;

Console.WriteLine($"A segunda tartaruga levou {dias_segunda} dias para chegar ao lago. Portanto, a primeira tartaruga teve que esperar por {espera}.");

// (Enem) Jogar baralho é uma atividade que estimula o raciocínio. Um jogo tradicional é a Paciência, que utiliza 52 cartas. Inicialmente são formadas sete colunas com as cartas. 
// A primeira coluna tem uma carta, a segunda tem duas cartas, a terceira tem três cartas, a quarta tem quatro cartas, e assim sucessivamente até a sétima coluna, 
// a qual tem sete cartas, e o que sobra forma o monte, que são as cartas não utilizadas nas colunas. A quantidade de cartas que forma o monte é:

int soma01 = 1 + 2 + 3 + 4 + 5 + 6 + 7;
int cartas_monte = 52 - soma01;

Console.WriteLine($"{cartas_monte} cartas formam o monte.");

// (CESGRANRIO) Uma pizzaria vende pizzas nos sabores calabresa, frango e quatro queijos. A borda pode ser tradicional ou recheada, e o tamanho pode ser médio ou grande. 
// Quantas combinações diferentes de pizza o cliente pode pedir, considerando apenas um sabor por vez?

int sabores = 3;
int bordas = 2;
int tamanhos = 2;

int combinacoes = sabores * bordas * tamanhos;

Console.WriteLine($"É possível realizar {combinacoes} combinações de pizza.");

// Descubra a lógica por trás de cada sequência e apresente corretamente o próximo elemento de cada uma delas:
// I) 1, 3, 5, 7, ? II) 2, 4, 8, 16, 32, 64, ? III) 0, 1, 4, 9, 16, 25, 36, ? IV) 4, 16, 36, 64, ? V) 1, 1, 2, 3, 5, 8, ? VI) 2, 10, 12, 16, 17, 18, 19, ?
