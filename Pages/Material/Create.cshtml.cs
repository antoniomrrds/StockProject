﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewData["SupplierId"] = new SelectList(_context.Suppliers, "Id", "Name");

            return Page();
        }

        [BindProperty]
        public StockProject.Models.Material Material { get; set; } = default!;

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

        public IActionResult OnGetGetQRCode(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            var qrcode = supplier.GenerateQRCode();
            return new JsonResult(qrcode);
        }
    }
}