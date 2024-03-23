﻿using System;
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

            var material = await _context.Materials.FirstOrDefaultAsync(m => m.Id == id);
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