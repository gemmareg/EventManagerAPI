using EventManagerAPI.Data;
using Microsoft.AspNetCore.Mvc;


namespace EventManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            try
            {
                var users = _context.Users.ToList();
                if (users.Count == 0)
                {
                    return NotFound("Users not available.");
                }
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
