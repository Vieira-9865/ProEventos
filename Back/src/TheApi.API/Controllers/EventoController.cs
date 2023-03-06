using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheApi.API.Data;
using TheApi.API.Models;

namespace TheApi.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
                public DataContext Context { get; }
        
        public EventoController(DataContext context)
        {
            this.Context = context;
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return Context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetbyId(int id)
        {
            return Context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "value post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"value put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"value Delete com id = {id}";
        }
    }
}
