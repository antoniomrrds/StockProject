using Microsoft.AspNetCore.Mvc.RazorPages;
using StockProject.Data;

namespace StockProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public int TotalMaterials { get; set; }
        public int TotalSuppliers { get; set; }

        public void OnGet()
        {
            TotalMaterials = _context.Materials.Count();
            TotalSuppliers = _context.Suppliers.Count();
        }
    }
}