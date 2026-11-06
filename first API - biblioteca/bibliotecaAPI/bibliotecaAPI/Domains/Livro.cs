namespace bibliotecaAPI.Domains
{
    // DOMAIN - representa um livro (cada linha vira um objeto livro)
    // ENTIDADE "livro"
    // representação de uma tabela no banco de dados
    // contém as informações que os livros têm
    public class Livro
    {
        public int IdLivro {  get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int AnoPublicacao { get; set; }
        public bool LivroAlugado { get; set; }
    }
}
