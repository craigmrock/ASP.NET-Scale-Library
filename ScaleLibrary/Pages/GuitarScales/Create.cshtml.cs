using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScaleLibrary.Data;
using ScaleLibrary.Models;

namespace ScaleLibrary.Pages.GuitarScales
{
    public class CreateModel : PageModel
    {
        private readonly ScaleLibrary.Data.ScaleLibraryContext _context;

        public CreateModel(ScaleLibrary.Data.ScaleLibraryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public GuitarScale GuitarScale { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.GuitarScale.Add(GuitarScale);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
