using bibliotecaAPI.Domains;

namespace bibliotecaAPI.Interfaces
{
    // vai dizer para o sistema suas funções
    // neste caso, vai listar as operações quer qualquer repositório precisa ter
    // a classe repository vai dizar COMO
    // contém as funções do sistema
    public interface ILivroRepository
    {
        List<Livro> ListarLivros();
        Livro AdicionarLivro(Livro livro);
        bool AtualizarLivro(int id, Livro livro);
        bool DeletarLivro(int id);
    }
}
