namespace APICatalogo.Models;

    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Estoque { get; set; }
        public DateTime ImagemUrl { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
