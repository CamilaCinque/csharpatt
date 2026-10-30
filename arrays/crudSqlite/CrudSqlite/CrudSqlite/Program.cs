
using Microsoft.Data.Sqlite;
using System.Threading.Channels;

// verificar a conexão com o banco de dados
// criar a tabela para trabalhar com a persistência dos dados

var conn = new SqliteConnection("Data Source = frutas.db");
conn.Open();

// criação da tabela

var criarTabela = conn.CreateCommand();
criarTabela.CommandText = @"CREATE TABLE IF NOT EXISTS frutas (
                                idFruta INTEGER PRIMARY KEY AUTOINCREMENT,
                                nomeFruta TEXT NOT NULL UNIQUE)";

criarTabela.ExecuteNonQuery();

Console.WriteLine($"Banco frutas criado em: {Path.GetFullPath("frutas.db")}");

List<string> listaFrutas = new List<string>();
int opcao;

do
{
    MostrarMenu();
    string entrada = Perguntar("Opção: ");

    if (!int.TryParse(entrada, out opcao))
    {
        opcao = -1;
    }

    switch (opcao)
    {
        case 1:
            ListarFrutas();
            break;

        case 2:
            AdicionarFrutas();
            break;

        case 0:
            Console.WriteLine("Até mais");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} 
while (opcao != 0);

// funções

void AdicionarFrutas()
{
    Console.WriteLine("Informe o nome da fruta nova: ");
    string frutaNova = Console.ReadLine()!;

    if (listaFrutas.Contains(frutaNova))
    {
        Console.WriteLine("Essa fruta já está na lista!");
    }
    else if (frutaNova == " ")
    {
        Console.WriteLine("O nome não pode ficar vazio!");
    }
    else
    {
        // adicionando a fruta no banco:

        var inserir = conn.CreateCommand();
        inserir.CommandText = "INSERT INTO frutas(nomeFruta) VALUES ($nomeFruta)";
        inserir.Parameters.AddWithValue("$nomeFruta", frutaNova);
        inserir.ExecuteNonQuery();

        // adicionando na lista:

        listaFrutas.Add(frutaNova);
        Console.WriteLine($"A {frutaNova} foi adicionada na lista com sucesso!");
    }
}

void ListarFrutas() {
    listaFrutas = new List<string>();

    var selecionarFrutas = conn.CreateCommand();
    selecionarFrutas.CommandText = "SELECT nomeFruta FROM frutas ORDER BY nomeFruta Asc";

    var leitor = selecionarFrutas.ExecuteReader();

    while (leitor.Read())
    {
        listaFrutas.Add(leitor.GetString(0));
    }

    if (listaFrutas.Count == 0)
    {
        Console.WriteLine("Não tem nada na lista!");
    }
    else
    {  
        foreach (var fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }
    }
};

string Perguntar(string mensagem)
{
    Console.WriteLine(mensagem);
    return (Console.ReadLine()!).Trim();
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("01 - Listar frutas");
    Console.WriteLine("02 - Adicionar frutas");
    Console.WriteLine("03 - Atualizar frutas");
    Console.WriteLine("04 - Remover frutas");
    Console.WriteLine("05 - Verificar se existe em frutas");
    Console.WriteLine("06 - Ordenar lista");
    Console.WriteLine("00 - Sair");
}