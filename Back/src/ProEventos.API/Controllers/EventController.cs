using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly ILogger<EventController> _logger;
        private readonly DataContext _context;

        public EventController(ILogger<EventController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get() => _context.Events;

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            try
            {
                return _context.Events.FirstOrDefault(eventActive => eventActive.EventId == id);
            }
            catch (System.Exception)
            {

                throw new Exception("teste");
            }
        }

        [HttpPost]
        public string Post() => "_event";

        [HttpPut]
        public string Put() => "_event";

        [HttpDelete]
        public string Delete() => "_event";
    }
}
