using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;

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
            return _context.Categorias.ToList();
        }

        [HttpGet("id:int", Name ="ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {

            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);
            
            if (categoria is null) return NotFound("Não encontrado...");

            return Ok(categoria);
        }

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

        [HttpPut("{id:int}")]

        public ActionResult Put(int id, Categoria categoria)
        {
            if(categoria == null) return BadRequest();

            _context.Entry(categoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(categoria);
        }


    }
}