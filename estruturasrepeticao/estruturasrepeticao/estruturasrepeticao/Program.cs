
////for (int i = 0; i < 5; i++)
////    {
////    Console.WriteLine(i);
////    }

////Console.Write("Informe a idade do Péricles: ");
////int idadePericles = int.Parse(Console.ReadLine()!);

////while (idadePericles != 57)
////{
////    Console.WriteLine("Tente novamente!");

////    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor!" : "Tente uma idade maior!");

////    idadePericles = int.Parse(Console.ReadLine()!);

////}

////Console.WriteLine("Você conseguiu adivinhar a idade do Péricles!");

////int idadePericles;

////do
////{
////    Console.Write("Informe a idade do Péricles: ");
////    idadePericles = int.Parse(Console.ReadLine()!);

////    if(idadePericles == 57)
////    {
////        Console.WriteLine("Você conseguiu adivinhar a idade do Péricles!");
////        break;
////    }

////    Console.WriteLine(idadePericles > 57 ? "Tente uma idade menor!" : "Tente uma idade maior!");

////}

////while (idadePericles != 57);

////string[] nomes = { "Camila", "Rafael", "Vânia", "Heloísa" };

////try
////{
////    foreach (string nome in nomes)
////    {
////        Console.WriteLine(nome);
////    }

////    // enquanto i for menor que o tamanho total da lista (4) mostre na tela o nome que está na posição i | depois de mostrar, some 1 ao valor de i e repita o processo:

////    for (int i = 0; i < nomes.Length; i++)
////    {
////        Console.WriteLine(nomes[i]);
////    }
////}

////catch (IndexOutOfRangeException)
////{

////    Console.WriteLine("O index está fora do alcance!");
////}

////somar os valores da lista:

////int[] numeros = { 2, 4, 6, 8 };

////var soma = 0;

////foreach (int numero in numeros)
////{
////    Console.WriteLine(numero);
////    soma += numero;
////}

////Console.WriteLine($"\nA soma dos números é: {soma}.");

//// crie um programa que vai pedir um numero para o usuario e o programa deve mostrar a tabuada dessa maneira: n * 1, n * 2,...

////Console.Write("Informe um número inteiro: ");
////int numeroInformado = int.Parse(Console.ReadLine());

////var produto = 1;

////for (int i = 1; i <= 10; i++)
////{
////    produto = numeroInformado * i;
////    Console.WriteLine($"{numeroInformado} x {i} = {produto}");
////}

//// faça com que o programa continue perguntando um numero para a tabuada até que o usuário decida sair do programa

////int numeroInformado;

////do {

////    Console.Write("Informe um número inteiro (informe 0 para encerrar): ");
////    numeroInformado = int.Parse(Console.ReadLine());

////    if (numeroInformado == 0)
////    {
////        Console.WriteLine("Encerrando...");
////        break;
////    }

////    var produto = 1;

////    for (int i = 1; i <= 10; i++)
////    {
////        produto = numeroInformado * i;
////        Console.WriteLine($"{numeroInformado} x {i} = {produto}");
////    }

////} while (numeroInformado != 0);

////var produto = 1;

////for (int i = 1; i <= 10; i++)
////{
////    produto = numeroInformado * i;
////    Console.WriteLine($"{numeroInformado} x {i} = {produto}");
////}

//// Média com foreach 
//// Faça um programa que leia 5 números e informe a soma e a média dos números.

//Console.Write("Informe o primeiro número: ");
//double n01 = double.Parse(Console.ReadLine());

//Console.Write("Informe o segundo número: ");
//double n02 = double.Parse(Console.ReadLine());

//Console.Write("Informe o terceiro número: ");
//double n03 = double.Parse(Console.ReadLine());

//Console.Write("Informe o quarto número: ");
//double n04 = double.Parse(Console.ReadLine());

//Console.Write("Informe o quinto número: ");
//double n05 = double.Parse(Console.ReadLine());

//double[] numeros = { n01, n02, n03, n04, n05 };

//double soma01 = 0;
//double contador = 0;

//foreach (double num in numeros)
//{
//    soma01 += num;
//    contador++;
//}

//Console.WriteLine($"\nA soma dos {contador} números informados é: {soma01}.");
//Console.WriteLine($"A média dos números informados é: {soma01 / contador}.");

//// Faça um programa que, dado um conjunto de N números determine o menor valor, o maior valor e a soma dos valores

//var maiorNum = 0;
//int menorNum = 0;
//var soma02 = 0;

//int[] numerosX = { 10, 130, 2, 6, 70, 100};

//foreach (int num in numerosX)
//{
//    soma02 += num;

//    if (num > maiorNum)
//    {
//        maiorNum = num;
//    }

//}

//menorNum = maiorNum;

//foreach (int num in numerosX)
//{ 

//    if (num < menorNum)
//{

//    menorNum = num;
//}
//}

//Console.WriteLine($"O maior número é: {maiorNum}.");
//Console.WriteLine($"A soma dos números é: {soma02}.");
//Console.WriteLine($"O menor número é: {menorNum}.");

//// Numa eleição existem três candidatos. Faça um programa que peça o número total de eleitores. Peça para cada eleitor votar e ao final mostrar o número de votos de cada candidato.

int contadorCandidato01 = 0;
int contadorCandidato02 = 0;
int contadorCandidato03 = 0;
int contadorVotosInvalidos = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Informe o número do seu candidato: ");
    string entradaVoto = (Console.ReadLine());

    if(int.TryParse(entradaVoto, out int voto )) {   

        if (voto == 1)
        {
        contadorCandidato01++;
        }
        else if (voto == 2)
        {
        contadorCandidato02++;

        }
        else if (voto == 3)
        {
        contadorCandidato03++;
        }
        else if (voto < 1 || voto > 3)
        {
        contadorVotosInvalidos++;
        }
    }
    else 
    {
        Console.Write("Entrada inválida!");
        contadorVotosInvalidos++;
    }
}

Console.WriteLine($"\nVotos candidato 01: {contadorCandidato01}");
Console.WriteLine($"Votos candidato 02: {contadorCandidato02}");
Console.WriteLine($"Votos candidato 03: {contadorCandidato03}");
Console.WriteLine($"Votos inválidos: {contadorVotosInvalidos}");
