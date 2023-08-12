using System.Collections.ObjectModel;
using APICatalogo.Context;

namespace APICatalogo.Models;

    public class Categoria
    {
        // Boa prática de inicializar a classe produto
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public ICollection<Produto> Produtos{ get; set; } 
        
    }
/*
*Uma categoria, possui uma coleção de produtos
* Ex: Higiene: Sabonete, shampoo, condicionador        
*/