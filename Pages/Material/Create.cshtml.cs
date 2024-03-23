using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockProject.Data;
using StockProject.Models;

namespace StockProject.Pages.Material
{
    public class CreateModel : PageModel
    {
        private readonly StockProject.Data.ApplicationDbContext _context;

        public CreateModel(StockProject.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Address");
            return Page();
        }

        [BindProperty]
        public StockProject.Models.Material Material { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Materials.Add(Material);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}