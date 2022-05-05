using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScaleLibrary.Data;
using ScaleLibrary.Models;

namespace ScaleLibrary.Pages.GuitarScales
{
    public class DeleteModel : PageModel
    {
        private readonly ScaleLibrary.Data.ScaleLibraryContext _context;

        public DeleteModel(ScaleLibrary.Data.ScaleLibraryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GuitarScale GuitarScale { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GuitarScale = await _context.GuitarScale.FirstOrDefaultAsync(m => m.ID == id);

            if (GuitarScale == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GuitarScale = await _context.GuitarScale.FindAsync(id);

            if (GuitarScale != null)
            {
                _context.GuitarScale.Remove(GuitarScale);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
