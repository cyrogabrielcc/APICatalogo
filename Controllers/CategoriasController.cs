using System.Net;
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
    [Route("[controller]")]
    public class CategoriasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return _context.Categorias.AsNoTracking().ToList();
        }

        // ----- GET PRODUTOS CATEGORIAS -----

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            return _context.Categorias.AsNoTracking().Include(p=>p.Produtos).ToList();
        }

        // ----- CATEGORIA ID -----

        [HttpGet("id:int", Name ="ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {

            var categoria = _context.Categorias.AsNoTracking().FirstOrDefault(c => c.CategoriaId == id);
            
            if (categoria is null) return NotFound("Não encontrado...");

            return Ok(categoria);
        }

        // ----- POST CATEGORIAS -----

        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (categoria == null) return BadRequest();

            _context.Categorias.Add(categoria);
            _context.SaveChanges();

            return new CreatedAtRouteResult
            (
                "ObterCategoria", 
                new {id=categoria.CategoriaId}, 
                categoria
            );
        }

        // ----- PUT CATEGORIAS -----

        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Categoria categoria)
        {
            if(categoria == null) return BadRequest();

            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(categoria);
        }

        // ----- DELETE CATEGORIAS -----
        
        [HttpDelete("{id:int}")]
        public ActionResult<Categoria> Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);

            if (categoria is null) return NotFound();

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return Ok(categoria);
        }
    }
}