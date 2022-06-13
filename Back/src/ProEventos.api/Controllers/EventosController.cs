using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.api.Models;
using ProEventos.api.Data;

namespace ProEventos.api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> get()
        {
            return _context.Eventos;
        }

        [HttpPost]
        public string Post() => "Exemplo de Post";

        [HttpDelete]
        public string Delete() => "Exemplo de Delete";

        [HttpPut("{id}")]
        public string Put() => "Exemplo de Put";

    }
}
