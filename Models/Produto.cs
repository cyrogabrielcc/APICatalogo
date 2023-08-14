using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models;

    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
      
        [Required]
        public string Nome { get; set; }
       
        [Required]
        [StringLength(80)]
        public string Descricao { get; set; }
        
        [Required]
        [Column(TypeName = "Decimal (10, 2)")]
        public decimal Preco { get; set; }
        
        [Required]
        public string Estoque { get; set; }
        
        [Required]
        [StringLength(80)]
        public string ImagemUrl { get; set; }
        
        public int CategoriaId { get; set; }
        
        public DateTime DataCadastro {get; set; }
        
        public Categoria Categoria { get; set; }
    }
