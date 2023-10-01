using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace APICatalogo.Models;

public class Categoria
    {
        // Boa prática de inicializar a classe produto
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Deve ter entre 2 e 50 caracteres", MinimumLength = 2 )]
        public string Nome { get; set; }
        
        [Required]
        [StringLength(300, ErrorMessage = "Deve ter entre 2 e 300 caracteres", MinimumLength = 1)]
        public string ImagemUrl { get; set; }
        
        public ICollection<Produto> Produtos{ get; set; } 
        
    }
/*
*Uma categoria, possui uma coleção de produtos
* Ex: Higiene: Sabonete, shampoo, condicionador        
*/