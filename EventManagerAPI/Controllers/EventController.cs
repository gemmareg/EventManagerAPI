using EventManagerAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EventManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            try
            {
                var events = _context.Events.ToList();
                if (events.Count == 0)
                {
                    return NotFound("Events not available.");
                }
                return Ok(events);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
