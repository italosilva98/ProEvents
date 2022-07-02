using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _event = new List<Event>
        {
            new Event()
            {
                EventId = 1,
                Theme = "Angular 11 and .NET 5",
                City = "SP",
                Batch = "1º",
                AmountPeople = 250,
                EventDate = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImageURL = "file.png"
            },
            new Event()
            {
                EventId = 2,
                Theme = "Angular 11 and .NET 5",
                City = "SP",
                Batch = "1º",
                AmountPeople = 250,
                EventDate = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImageURL = "file.png"
            }
        };

        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Event> Get() => _event;

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id) => _event.Where(eventActive => eventActive.EventId == id);

        [HttpPost]
        public IEnumerable<Event> Post() => _event;

        [HttpPut]
        public IEnumerable<Event> Put() => _event;

        [HttpDelete]
        public IEnumerable<Event> Delete() => _event;
    }
}
