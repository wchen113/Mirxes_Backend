using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirxes_Backend.Data;
using Mirxes_Backend.Entities;

namespace Mirxes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly DataContext _context;

        public SuppliersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Suppliers>>> GetAllSuppliers()
        {
            var suppliers = await _context.Suppliers.Where(a => !a.IsDeleted).ToListAsync();
            return Ok(suppliers);
        }
    }
}
