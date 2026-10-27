// Exercícios Condicionais

// Nível Fácil

// 1. Temperatura
// Leia uma temperatura em graus Celsius.
// Informe se está **frio** (abaixo de 15) ou **agradável/quente**.

Console.Write("Informe a temperatura (somente números): ");
double temperatura = double.Parse(Console.ReadLine());

string resultado = temperatura < 15 ? "frio" : "quente";

Console.WriteLine($"Está {resultado}.");

// 2. Número válido
// Leia um número.
// Informar se ele é maior que 100.

Console.Write("Informe um número: ");
double numero = double.Parse(Console.ReadLine());

string mensagem = numero > 100 ? $"O número {numero} é maior que 100!" : $"O número {numero} NÃO é maior que 100.";

Console.WriteLine(mensagem);

// 3. Senha simples
// Leia uma senha (string).
// Verifique se ela é igual a `"123"`.

Console.Write("Informe a sua senha: ");
string senha = Console.ReadLine();

string senhaCorreta = senha == "123" ? "correta" : "incorreta";

Console.WriteLine($"A senha está {senhaCorreta}.");

// 4. Número negativo
// Leia um número.
// Se for negativo, mostre "Número inválido".

Console.Write("Informe um número: ");
double numeroInformado = double.Parse(Console.ReadLine());

string numeroValido = numeroInformado > 0 ? "Número válido." : "Número inválido.";

Console.WriteLine(numeroValido);

// 5. Ternário – positivo ou negativo
// Leia a idade de uma pessoa e use operador ternário para mostrar:
// - `"Cadastro permitido"` se tiver 16 anos ou mais
// - `"Cadastro não permitido"` se tiver menos de 16 anos

Console.Write("Informe a sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine(idade >= 16 ? "Cadastro permitido!" : "Cadastro não permitido!");

// 6. Turno do dia (switch)
// Leia um número:
// - 1 → Manhã
// - 2 → Tarde
// - 3 → Noite
// Qualquer outro → Inválido

Console.Write("Escolha uma opção: \n\n1. Manhã\n2. Tarde\n3. Noite\n\n");
int turno = int.Parse(Console.ReadLine());

switch (turno)
{
    case 1:
        Console.WriteLine("Você escolheu a opção: manhã.");
        break;

    case 2:
        Console.WriteLine("Você escolheu a opção: tarde.");
        break;

    case 3:
        Console.WriteLine("Você escolheu a opção: noite.");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}

// 7. Menu simples (switch)
// Leia uma opção:
// - 1 → "Novo jogo"
// - 2 → "Carregar jogo"
// - 3 → "Sair"

Console.Write("Escolha uma opção: \n\n1. Novo jogo\n2. Carregar jogo\n3. Sair\n\n");
int opcao01 = int.Parse(Console.ReadLine());

switch (opcao01)
{
    case 1:
        Console.WriteLine("Você escolheu a opção: novo jogo.");
        break;

    case 2:
        Console.WriteLine("Você escolheu a opção: carregar jogo.");
        break;

    case 3:
        Console.WriteLine("Você escolheu a opção: sair.");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
}

// ## Nível Médio

// 1. Classificação de idade
// Leia a idade e classifique:
// - Criança (até 12)
// - Adolescente (13 a 17)
// - Adulto (18 ou mais)

Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine("Criança.");

} else if (idade > 12 && idade <= 17)
{
    Console.WriteLine("Adolescente.");
} else
{
    Console.WriteLine("Adulto.");
}

// 2. Maior entre dois (ternário)
// Leia dois números e use operador ternário para mostrar o maior.

// 3. Acesso com duas condições
// Leia:
// - idade
// - possui ingresso (true / false)
// Só pode entrar se tiver mais de 18 **ou** possuir ingresso.

// 4. Número dentro de faixa inválida
// Leia um número.
// Se estiver fora do intervalo de 0 a 10, mostrar "Valor inválido".

// 5. Desconto por idade
// Leia a idade:
// - Menor de 18 → sem desconto
// - 18 a 59 → 10%
// - 60 ou mais → 20%

// 6. Desconto com ternário
// Leia o valor de uma compra:
// - >= 200 → 15% desconto
// - < 200 → 5% desconto

// 7. Calculadora com switch
// Leia dois números e uma operação (+, -, *, /).

// 8. Dia útil ou fim de semana (switch)
// Leia un número de 1 a 7.
// - 1 e 7 → Fim de semana
// - 2 a 6 → Dia útil

// 9. Plano de internet (switch)
// Leia o plano:
// - "Básico" → 10MB
// - "Intermediário" → 50MB
// - "Premium" → 100MB

// ---

// ## Nível Difícil

// 1. Sistema de notas completo
// Leia a nota (0 a 10):
// - >= 7 → Aprovado
// - >= 5 e < 7 → Recuperação
// - < 5 → Reprovado
// Se a nota for inválida (< 0 ou > 10), informar isso.

// 2. Triângulo (simplificado)
// Leia três números.
// Verifique se todos são maiores que zero.
// Se sim, informe "Pode formar um triângulo", senão "Inválido".

// 3. Calculadora simples
// Leia:
// - número 1
// - número 2
// - operador (+, -, *, /)
// Execute a operação correspondente usando if/else.

// 4. Login com tentativas
// Leia usuário e senha.
// Se estiver correto (usuário e senha), acesso liberado.
// Caso contrário, acesso negado.

// 5. Ternário encadeado (desafio)
// Leia um número e classifique usando **apenas operador ternário**:
// - Negativo
// - Zero
// - Positivo

// 6. Menu de operações completo (switch + if)
// Leia:
// - número 1
// - número 2
// - operação (+, -, *, /)
// Use `switch` para escolher a operação e valide divisão por zero com `if`.

// 7. Escolha de bebida (switch)
// Leia uma opção:
// - 1 → Água
// - 2 → Refrigerante
// - 3 → Suco
// Mostre também o preço (você pode definir os preços de forma aleatória).
