﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookTrackingApp.Data;
using BookTrackingApp.Models;

namespace BookTrackingApp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly BookTrackingApp.Data.BookTrackingAppContext _context;

        public CreateModel(BookTrackingApp.Data.BookTrackingAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BookId"] = new SelectList(_context.Book, "BookId", "BookId");
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Category == null || Category == null)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
