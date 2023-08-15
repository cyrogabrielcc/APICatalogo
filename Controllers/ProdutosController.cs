using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }
       
       
        // -------------- Retornando todos os produtos --------------
       
        [HttpGet]
        public  ActionResult<IEnumerable<Produto>> Get(){
            if(_context.Produtos.ToList() is null)
            {
                return NotFound();
            }
            return _context.Produtos.ToList();
        }

        
        // -------------- Retornando um produto --------------

        [HttpGet("{id:int}", Name = "ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            // Faz um lambda para pegar e selecionar o produto pelo id inserido na operação
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);
            
            if(produto == null)
            {
                return NotFound();
            }

            return produto;
        }


        // -------------- Criando um produto --------------
        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null) return BadRequest();
            
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            
            // Retorna a rota específica do produto
            return new CreatedAtRouteResult
            (
            "ObterProduto", 
             new{id=produto.ProdutoId}, 
             produto
            );
        }

        // -------------- Atualiza um produto --------------
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if(id != produto.ProdutoId)
            {
                return BadRequest();
            }
            
            // Sinalizando a modificação do objeto
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(produto);

        }
    }
}