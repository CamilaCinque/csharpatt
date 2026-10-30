
// array -> estrutura de dados unidimensional
// aceita somente um único tipo de dados (int, str, ...)
// estrutura (coleção) de tamanho fixo (definido no momento da criação)

//int[] valores = new int[5];

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.Write($"Informe o {i+1}º valor: ");
//    valores[i] = int.Parse(Console.ReadLine()!);
//}

//foreach (int var in valores)
//{
//    Console.WriteLine(var);
//}

// crie uma lista de frutas
// crie um programa para adicionar, remover, verificar se está na lista, atualizar uma fruta existente 

List<string> frutas = new List<string> { "maçã", "morango", "mexerica", "manga", "melancia" };

Console.Write("Selecione uma opção: \n\n01 - Adicionar uma fruta \n02 - Remover uma fruta \n03 - Atualizar uma fruta já existente \n" +
    "04 - Verificar se uma fruta está na lista \n05 - Encerrar\n\n");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int opcao))
{
    switch (opcao)
    {
        case 1:

            Console.WriteLine($"\nVocê escolheu a opção {opcao}!");

            Console.Write("Informe o nome da fruta para incluir na lista: ");
            string fruta = Console.ReadLine();

            frutas.Add(fruta);

            Console.WriteLine("\nSucesso! A lista foi atualizada:");
            Console.WriteLine(string.Join(", ", frutas));

            break;

        case 2:

            Console.WriteLine($"\nVocê escolheu a opção {opcao}.");

            Console.Write("Informe o nome da fruta para remover da lista: ");
            Console.WriteLine(string.Join(", ", frutas));

            string removerFruta = Console.ReadLine();

            if (frutas.Contains(removerFruta))
            {

                frutas.Remove(removerFruta);

                Console.Write("\nSucesso! A lista foi atualizada: ");
                Console.WriteLine(string.Join(", ", frutas));

            }

            else
            {
                Console.WriteLine($"\nA fruta '{removerFruta}' não está na lista.");
            }

            break;

        case 3:

            // indexat

            Console.WriteLine($"Você escolheu a opção {opcao}.");

            Console.Write("Informe a fruta que deseja atualizar na lista: ");
            Console.WriteLine(string.Join(", ", frutas));

            int posicaoFruta = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome da fruta que deseja inserir na posição {posicaoFruta}: ");
            string atualizarFruta02 = Console.ReadLine();

            if (posicaoFruta > frutas.Count || posicaoFruta < frutas.Count)
            {
                Console.WriteLine("Valor não existente na lista.");
            }

            else

            {
                frutas[posicaoFruta] = atualizarFruta02;

                Console.Write("\nSucesso! A lista foi atualizada: ");
                Console.WriteLine(string.Join(", ", frutas));
            }

            break;

        case 4:

            Console.WriteLine($"Você escolheu a opção {opcao}.");

            break;

        case 5:

            Console.WriteLine($"Você escolheu a opção {opcao}.");

            break;

        default:

            Console.WriteLine($"Opção inválida. Selecione uma opção entre 01 e 05.");

            break;
    }
}
else
{
    Console.WriteLine("Valor inválido. Digite somente números.");
}

//Console.WriteLine(string.Join(", ", frutas));

//frutas.Add("melão");
//frutas.Remove("mexerica");

//Console.WriteLine();
//Console.WriteLine(string.Join(", ", frutas));

//frutas[3] = "abacaxi";

//Console.WriteLine();
//Console.WriteLine(string.Join(", ", frutas));

//if (frutas.Contains("morango"))

//{
//    Console.WriteLine("\no item `morango` está na lista!");
//}
//else
//{
//    Console.WriteLine("\no item `morango NÃO está na lista.");
//}