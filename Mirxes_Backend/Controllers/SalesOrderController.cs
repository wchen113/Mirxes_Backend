using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirxes_Backend.Data;
using Mirxes_Backend.Entities;

namespace Mirxes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        private readonly DataContext _context;

        public SalesOrderController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SalesOrder>>> GetAllSalesOrder()
        {
            var salesOrder = await _context.SalesOrder.Where(a => !a.IsDeleted).ToListAsync();
            return Ok(salesOrder);
        }
    }
}
