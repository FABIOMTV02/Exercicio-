using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core.Controllers
{
    [Produces("application/json")]
    [Route("api/Autores")]
    public class AutoresController : Controller
    {
        private readonly IAutorRepositorio _context;
        public AutoresController(IAutorRepositorio autorRepositorio)
        {
            _context = autorRepositorio;       
        }
        
        [HttpGet]
        public async Task<List<Autor>> Get()
        {
            return await _context.ListAsync();
        }

        //GET: api/autores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {

            }
        }
        public IActionResult Index()
        {
            return View()
        }

        

    }
}
