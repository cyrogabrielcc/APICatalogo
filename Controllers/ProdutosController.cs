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

        

    }
}