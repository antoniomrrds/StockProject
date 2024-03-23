using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StockProject.Data;
using StockProject.Models;

namespace StockProject.Pages.Material
{
    public class IndexModel : PageModel
    {
        private readonly StockProject.Data.ApplicationDbContext _context;

        public IndexModel(StockProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<StockProject.Models.Material> Material { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Material = await _context.Materials
                .Include(m => m.Supplier).ToListAsync();
        }
    }
}