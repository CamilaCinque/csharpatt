using bibliotecaAPI.Domains;
using bibliotecaAPI.Interfaces;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace bibliotecaAPI.Services
{
    public class LivroService // define a classe "LivroService" 
    {
        private readonly ILivroRepository _livroRepository;

        // cria uma variável interna (_livroRepository) para guardar o repositório q repositorio?
        // private: só pode ser usada dentro desta classe livroservice?
        // readonly: "apenas leitura" depois que a _livroRepository receber o repositório (contém os métodos) no construtor, não é mais possível alterá-la
        // ILivroRepository - o tipo da variável. não guarda um banco de dados direto, mas qualquer
        // classe que siga o contrato (interface) ILivroRepository.
	    // dentro dos parênteses (ILivroRepository livroRepository), exige:
        // "Para eu nascer, você precisa me passar um repositório válido".
        public LivroService(ILivroRepository livroRepository) // construtor da classe (livro service)
        {
            // pega o repositório enviado nos parênteses do construtor (livroRepository) e joga para dentro daquela 
            // variável privada que criamos lá em cima (_livroRepository). agora a classe toda tem acesso ao repositório.

            _livroRepository = livroRepository;
        }

        public List<Livro> Listar()
        {
            return _livroRepository.ListarLivros();
        }
        public Livro Adicionar(Livro livro)
        {
            return _livroRepository.AdicionarLivro(livro);
        }

        public bool Atualizar(int id, Livro livro)
        {
            return _livroRepository.AtualizarLivro(id, livro);
        }

        public bool Deletar(int id)
        {
            return _livroRepository.DeletarLivro(id);
        }

    }
}
