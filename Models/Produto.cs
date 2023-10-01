using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

    [Table("Produtos")]
    public class Produto : IValidatableObject
    {
        // --------------------------------------------
        [Key]
        public int ProdutoId { get; set; }

        // --------------------------------------------
        [Required(ErrorMessage = "Nome obrigatório" )]
        [StringLength(20, ErrorMessage = "entre 3 e 20 caracteres", MinimumLength = 3)]
        public string Nome { get; set; }
       
        // --------------------------------------------
        [Required(ErrorMessage = "Descrição obrigatória" )]
        [StringLength(80, ErrorMessage = "entre 3 e 20 caracteres", MinimumLength = 5)]
        public string Descricao { get; set; }
        
        // --------------------------------------------
        [Required(ErrorMessage = "Preço obrigatório" )]
        [Range(1,10000, ErrorMessage = "Os preços devem estar entre R$ {1} e R$ {2}")]
        public decimal Preco { get; set; }
        
        // --------------------------------------------
        [Required(ErrorMessage = "Valor de estoque obrigatório" )]
        public int Estoque { get; set; }
        
        // --------------------------------------------
        [Required(ErrorMessage="Favor inserir a URL da imagem")]
        [StringLength(300, ErrorMessage = "Deve ter entre 2 e 300 caracteres", MinimumLength = 1)]
        public string ImagemUrl { get; set; }
        
        // --------------------------------------------
        public int CategoriaId { get; set; }
        
        // --------------------------------------------
        public DateTime DataCadastro {get; set; }
        
        // --------------------------------------------
        [JsonIgnore]
        public Categoria Categoria { get; set; }


    // Validando o produto

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!string.IsNullOrEmpty(this.Nome))
        {
            var priletra = this.Nome[0].ToString();

            // Validando se a pimeira letra é maiúscula
            if (priletra != priletra.ToUpper()) yield return new ValidationResult("A primeira letra deve ser maiúscula", new[] {nameof(this.Nome)});

            // Validando o Estoque
            if (this.Estoque <= 0) yield return new ValidationResult("O Estoque não deve ser 0!", new[] { nameof(this.Estoque) });

            // Validando o Preço
            if (this.Preco <= 0) new ValidationResult("O preço não deve ser 0!", new[] { nameof(this.Preco) });
        }
    }
}
