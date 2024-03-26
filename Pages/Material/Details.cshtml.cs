using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace StockProject.Pages.Material
{
    public class DetailsModel : PageModel
    {
        private readonly StockProject.Data.ApplicationDbContext _context;

        public DetailsModel(StockProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public StockProject.Models.Material Material { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var material = await _context.Materials
                    .Include(m => m.Supplier)
                    .FirstOrDefaultAsync(m => m.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            else
            {
                Material = material;
            }
            return Page();
        }
    }
}