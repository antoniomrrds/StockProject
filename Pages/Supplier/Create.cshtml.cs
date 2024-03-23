﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StockProject.Data;
using StockProject.Models;

namespace StockProject.Pages.Supplier
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
            return Page();
        }

        [BindProperty]
        public StockProject.Models.Supplier Supplier { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Supplier.QRCode = $"{Supplier.CNPJ}/{Supplier.CEP}/CAD.${Supplier.CreatedAt}";

            _context.Suppliers.Add(Supplier);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}