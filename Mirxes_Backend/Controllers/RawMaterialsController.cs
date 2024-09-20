using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirxes_Backend.Data;
using Mirxes_Backend.Entities;

namespace Mirxes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawMaterialsController : ControllerBase
    {
        private readonly DataContext _context;

        public RawMaterialsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("items/names")]
        public async Task<ActionResult<List<ItemDto>>> GetItemNames()
        {
            var itemNames = await _context.Items
                                          .Where(i => !i.IsDeleted)
                                          .Select(i => new ItemDto
                                          {
                                              ItemName = i.ItemName,
                                              ItemNo = i.ItemNo
                                          })
                                          .Distinct()
                                          .ToListAsync();

            return Ok(itemNames);
        }

        /// <summary>
        /// Retrieves a list of distinct item names for dropdown.
        /// </summary>
        /// <returns>List of item names.</returns>
        [HttpGet("dropdown")]
        public async Task<ActionResult<List<ItemDropdownDto>>> GetItemDropdown()
        {
            var itemNamesResult = await GetItemNames();

            if (itemNamesResult.Result is OkObjectResult okResult)
            {
                var itemNames = (List<ItemDto>)okResult.Value;
                var dropdownOptions = itemNames.Select(i => new ItemDropdownDto
                {
                    ItemName = i.ItemName,
                    ItemNo = i.ItemNo
                }).ToList();

                return Ok(dropdownOptions);
            }

            return itemNamesResult.Result;
        }

        private async Task<string> GetTableNameAsync(string itemName)
        {
            var item = await _context.Items.FirstOrDefaultAsync(i => i.ItemName == itemName && !i.IsDeleted);
            if (item == null)
            {
                throw new ArgumentException("Invalid item name or item is deleted");
            }
            return item.ItemName;
        }

        [HttpGet("table")]
        public async Task<ActionResult<IEnumerable<RawMaterials>>> GetTable([FromQuery] string itemName)
        {
            if (string.IsNullOrWhiteSpace(itemName))
            {
                return BadRequest("Item name is required.");
            }

            string validItemName;
            try
            {
                validItemName = await GetTableNameAsync(itemName);
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex.Message);
            }

            // Use parameterized queries to avoid SQL injection
            var query = $"SELECT * from rawmaterials where Name = '[{validItemName}] '";
            var result = await _context.RawMaterials
                                       .FromSqlRaw(query)
                                       .ToListAsync();

            return Ok(result);
        }

        /// <summary>
        /// Retrieves all raw materials that are not deleted.
        /// </summary>
        /// <returns>List of raw materials.</returns>
        [HttpGet]
        public async Task<ActionResult<List<RawMaterials>>> GetAllRawMaterials()
        {
            var rawMaterials = await _context.RawMaterials
                                             .Where(a => !a.IsDeleted)
                                             .ToListAsync();
            return Ok(rawMaterials);
        }
    }

    public class ItemDropdownDto
    {
        public string? ItemName { get; set; }
        public string? ItemNo { get; set; }
    }

    public class ItemDto
    {
        public string? ItemName { get; set; }
        public string? ItemNo { get; set; }
    }


}
