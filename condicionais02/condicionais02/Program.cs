
//Console.Write("informe a sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//Console.Write("possui título? (sim/não");
//string possuiTitulo = Console.ReadLine();

//if (idade >= 18 && idade <= 70)
//{
//    Console.WriteLine($"O voto é obrigatório!");

//    if(possuiTitulo != "sim")
//    {
//        Console.WriteLine("Regularize o seu título de eleitor antes da votar.");
//    }

//}
//else if (idade < 16)
//{
//    Console.WriteLine($"Você não pode votar.");

//}
//else
//{
//    Console.WriteLine($"O voto é facultativo.");
//}

// leia uma nota de 0 a 10 sem deixar o programa quebrar. use o double.TryParse no lugar de double.Parse.
// texto que não é número - entrada inválida: "digite um número"
// fora de 0 a 10 - nota fora da faixa
// 9 ou mais - conceito A | 7 ou mais - conceito B | 5 ou mais - conceito C | abaixo de 5 - conceito D

Console.Write("Informe a sua nota: ");
string entrada = Console.ReadLine();

if (double.TryParse(entrada, out double nota))
{
    if (nota >= 9)
    {
        Console.WriteLine("Conceito: A");
    }
    else if (nota >= 7)
    {
        Console.WriteLine("Conceito: B");
    }
    else if (nota >= 5)
    {
        Console.WriteLine("Conceito: C");
    }
    else if (nota < 0 || nota > 10)
    {
        Console.WriteLine("Entrada inválida! Tente novamente digitando números entre 0 e 10.");
    }
    else
    {
        Console.WriteLine("Conceito: D");
    }
}
else
{
    Console.WriteLine("Entrada inválida! Tente novamente digitando apenas números.");
}

// leia a idade, se é estudante, o dia da semana (1 = domingo ... 7 = sábado) e se a sessão é a 3D. calcule o preço:

// preço base: R$40
// meia-entrada (50%) se a idade for menor que 12, maior ou igual a 60, ou se for estudante
// terca-feira (dia 03), mais de 20% de desconto sobre o valor já calculado.
// sessão 3D: soma R$8,00 depois dos descontos
// idade fora de 0 a 120 -> idade inválida / dia fora de 1 a 7 -> dia inválido


Console.Write("Informe a sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("Informe o dia da semana: \n\n1 - domingo\n2 - segunda-feira\n3 - terça-feira\n4 - quarta-feira\n5 - quinta-feira\n6 - sexta-feira\n7 - sábado\n\n");
int diaSemana = int.Parse(Console.ReadLine()!);

Console.Write("Você é estudante? (sim/não): ");
string estudante = Console.ReadLine()!;

Console.Write("A sessão é 3D? (sim/não): ");
string sessao3D = Console.ReadLine()!;


double precoBase = 40;
double precoAtualizado = 0;
double soma = 0;

if (idade < 0 || idade > 120)
{
    Console.WriteLine("Idade inválida!");
    return;
}

if (diaSemana < 1 || diaSemana > 7)
{
    Console.WriteLine("Dia da semana inválido!");
    return;
}

if (idade < 12 || idade >= 60 || estudante == "sim")
{
    precoAtualizado = precoBase - (precoBase * 0.5);
}
else
{
    precoAtualizado = precoBase;
}

if (diaSemana == 3)
{
    precoAtualizado = precoAtualizado - (precoAtualizado * 0.2);
}
else
{
    precoAtualizado = precoAtualizado;
}

if (sessao3D == "sim")
{
    soma = 8;
}
else
{
    soma = 0;
}

precoAtualizado = precoAtualizado + soma;
Console.WriteLine($"Preço final: R${precoAtualizado},00");

// leia o limite da via e a velocidade medida (km/h)
// calcule o percentual acima do limite com: (velocidade - limite) * 100 / limite e classifique com um switch case
// regras: 0% ou menos - dentro do limite / até 20% - infração média / +20% até 50% - infração grave / acima de 50% - infração gravíssima
// limite menor ou igual a 0, ou velocidade negativa - dados invalidos

Console.Write("Informe a velocidade máxima da via (apenas números): ");
int velocidadeVia = int.Parse(Console.ReadLine()!);

Console.Write("Informe a velocidade medida (apenas números): ");
int velocidadeMedida = int.Parse(Console.ReadLine()!);

if (velocidadeMedida <= 0 || velocidadeVia <= 0)
{
    Console.WriteLine("Dados inválidos!");
    return;
}

int calculoVelocidade = (velocidadeMedida - velocidadeVia) * 100 / velocidadeVia;

string classificacao = calculoVelocidade switch
{
    <= 0 => "Dentro da média!",
    <= 20 => "Infração média!",
    <= 50 => "Infração grave!",
    _ => "Infração gravíssima!"
};

if (calculoVelocidade <= 0)
{
    Console.WriteLine($"\n{classificacao}");
}
else
{
    Console.WriteLine($"\n{calculoVelocidade}% acima da velocidade máxima. {classificacao}");
}