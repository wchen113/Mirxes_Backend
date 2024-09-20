using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirxes_Backend.Data;
using Mirxes_Backend.Entities;

namespace Mirxes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUser()
        {
            var users = await _context.Users.Where(a => !a.IsDeleted).ToListAsync();
            return Ok(users);
        }
    }
}
