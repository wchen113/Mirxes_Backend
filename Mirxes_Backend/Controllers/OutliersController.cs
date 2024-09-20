using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirxes_Backend.Data;
using Mirxes_Backend.Entities;

namespace Mirxes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutliersController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILogger<OutliersController> _logger;

        public OutliersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Outliers>>> GetAllOutliers()
        {
            try
            {
                var outliers = await _context.Outliers.Where(a => !a.IsDeleted).ToListAsync();
                return Ok(outliers);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occurred while retrieving outliers.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRequiredToPostDate(int id, [FromBody] UpdateRequiredToPostDateDto updateDto)
        {
            if (updateDto.RequiredToPostDate < 0)
            {
                return BadRequest("RequiredToPostDate must be a non-negative integer.");
            }

            try
            {
                // Retrieve the specific Outliers record
                var outlier = await _context.Outliers
                    .FirstOrDefaultAsync(o => o.Id == id && !o.IsDeleted);

                if (outlier == null)
                {
                    return NotFound("Outlier record not found.");
                }

                // Update the Required_to_Post_Date field
                outlier.Required_to_Post_Date += updateDto.RequiredToPostDate;

                // Retrieve the associated SalesOrder record
                //var salesOrder = await _context.SalesOrder
                //    .FirstOrDefaultAsync(so => so. == outlier.PO_Number);

                //if (salesOrder == null)
                //{
                //    return NotFound("SalesOrder record not found.");
                //}

                // Update the EstimatedLeadTime field
                //salesOrder.EstimatedLeadTime += updateDto.RequiredToPostDate;

                // Save the changes to the database
                await _context.SaveChangesAsync();

                return Ok(new { message = "Required_to_Post_Date and EstimatedLeadTime have been updated successfully.", updatedOutlier = outlier });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the outlier and sales order.");
                return StatusCode(500, "An error occurred while updating the outlier and sales order.");
            }
        }

    }
    public class UpdateRequiredToPostDateDto
    {
        public int PO_Number { get; set; }
        public int RequiredToPostDate { get; set; }
    }


}
