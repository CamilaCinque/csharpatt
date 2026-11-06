
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

        case 3:
            AtualizarFrutas();
            break;

        case 4:
            DeletarFrutas();
            break;

        case 5:
            VerificarFrutas();
            break;

        case 6:
            OrdenarFrutas();
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

void OrdenarFrutas()
{
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
        Console.WriteLine(string.Join(", ", listaFrutas));

    }
}

void VerificarFrutas()
{
    Console.WriteLine("Informe o nome da fruta que deseja verificar se está na lista: ");
    string verificarFruta = Console.ReadLine()!;

    if (listaFrutas.Contains(verificarFruta))
    {
        Console.WriteLine($"A fruta {verificarFruta} está na lista!");
    }
    else
    {
        Console.WriteLine("O valor não está na lista.");
    }
 
}
void DeletarFrutas()
{
    ListarFrutas();

    Console.Write("\nQual fruta você deseja deletar?: ");
    string deletarFruta = Console.ReadLine()!;

    if (!listaFrutas.Contains(deletarFruta) || deletarFruta == " ")
    {
        Console.WriteLine("Informe uma fruta presente na lista.");
    }
    else
    {
        // atualizando a lista:

        listaFrutas.Remove(deletarFruta);

        Console.WriteLine($"A fruta {deletarFruta} foi removida com sucesso!");

        // atualizando o banco:

        var atualizar = conn.CreateCommand();
        atualizar.CommandText = ("DELETE FROM frutas WHERE nomeFruta = $deletarFruta");
        atualizar.Parameters.AddWithValue("$deletarFruta", deletarFruta);
        atualizar.ExecuteNonQuery();
    }
}
void AtualizarFrutas()
{
    ListarFrutas();

    Console.Write("\nQual fruta você deseja atualizar?: ");
    string atualizarFruta = Console.ReadLine()!;

    if (!listaFrutas.Contains(atualizarFruta) || atualizarFruta == " ")
    {
        Console.WriteLine("Valor não existente na lista.");
        return;
    }

    Console.Write($"Qual fruta você deseja inserir no lugar de {atualizarFruta}?: ");
    string novaFruta = Console.ReadLine()!;

    if (listaFrutas.Contains(novaFruta))
    {
        Console.WriteLine("Valor já existente na lista.");
    }

    else

    {
        // atualizando a lista:

        int posicaoFruta = listaFrutas.IndexOf(atualizarFruta);
        listaFrutas[posicaoFruta] = novaFruta;

        Console.WriteLine($"A fruta {atualizarFruta} foi atualizada para {novaFruta} com sucesso!");

        // atualizando o banco:

        var atualizar = conn.CreateCommand();
        atualizar.CommandText = ("UPDATE frutas SET nomeFruta = $novoNome WHERE nomeFruta = $antigoNome");
        atualizar.Parameters.AddWithValue("$novoNome", novaFruta);
        atualizar.Parameters.AddWithValue("$antigoNome", atualizarFruta);
        atualizar.ExecuteNonQuery();

        listaFrutas[posicaoFruta] = novaFruta;
        Console.WriteLine($"A fruta '{atualizarFruta}' foi atualizada para '{novaFruta}' com sucesso!");
    }
}
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
        Console.WriteLine($"{frutaNova} foi adicionada na lista com sucesso!");
    }
}

void ListarFrutas() {
    listaFrutas = new List<string>();

    var selecionarFrutas = conn.CreateCommand();
    selecionarFrutas.CommandText = "SELECT nomeFruta FROM frutas";

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
        Console.WriteLine(string.Join(", ", listaFrutas));

    }
}
;

string Perguntar(string mensagem)
{
    Console.Write(mensagem);
    return (Console.ReadLine()!).Trim();
}

void MostrarMenu()
{
    Console.WriteLine();
    Console.WriteLine("01 - Listar frutas");
    Console.WriteLine("02 - Adicionar frutas");
    Console.WriteLine("03 - Atualizar frutas");
    Console.WriteLine("04 - Remover frutas");
    Console.WriteLine("05 - Verificar se existe na lista 'frutas'");
    Console.WriteLine("06 - Ordenar lista");
    Console.WriteLine("00 - Sair");
}