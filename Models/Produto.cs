using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        // --------------------------------------------
        [Required(ErrorMessage = "Nome obrigatório" )]
        [MaxLength(80)]
        public string Nome { get; set; }
       
        // --------------------------------------------
        [Required(ErrorMessage = "Descrição obrigatória" )]
        [StringLength(80)]
        public string Descricao { get; set; }
        
        // --------------------------------------------
        [Required(ErrorMessage = "Preço obrigatório" )]
        [Column(TypeName = "Decimal (10, 2)")]
        public decimal Preco { get; set; }
        
        // --------------------------------------------
        [Required(ErrorMessage = "Valor de estoque obrigatório" )]
        public int Estoque { get; set; }
        
        // --------------------------------------------
        [Required(ErrorMessage="Favor inserir a URL da imagem")]
        [StringLength(80)]
        public string ImagemUrl { get; set; }
        
        // --------------------------------------------
        public int CategoriaId { get; set; }
        
        // --------------------------------------------
        public DateTime DataCadastro {get; set; }
        
        // --------------------------------------------
        [JsonIgnore]
        public Categoria Categoria { get; set; }
    }
