using UnRaccoonApi.Models;
using UnRaccoonApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UnRaccoonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly SupportService _supportService;

        public TicketController(SupportService supportService)
        {
            _supportService = supportService;
        }

        [HttpGet]
        public ActionResult<List<Ticket>> Get() =>
            _supportService.Get();

        [HttpGet("{id:length(24)}", Name = "GetTicket")]
        public ActionResult<Ticket> Get(string id)
        {
            var ticket = _supportService.Get(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        [HttpPost]
        public ActionResult<Ticket> Create(Ticket ticket)
        {
            _supportService.Create(ticket);

            return CreatedAtRoute("GetTicket", new { id = ticket.Id.ToString() }, ticket);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Ticket ticketIn)
        {
            var ticket = _supportService.Get(id);

            if (ticket == null)
            {
                return NotFound();
            }

            _supportService.Update(id, ticketIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var ticket = _supportService.Get(id);

            if (ticket == null)
            {
                return NotFound();
            }

            _supportService.Remove(ticket.Id);

            return NoContent();
        }
    }
}