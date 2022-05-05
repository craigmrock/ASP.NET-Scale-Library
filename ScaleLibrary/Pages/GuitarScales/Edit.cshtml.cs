using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScaleLibrary.Data;
using ScaleLibrary.Models;

namespace ScaleLibrary.Pages.GuitarScales
{
    public class EditModel : PageModel
    {
        private readonly ScaleLibrary.Data.ScaleLibraryContext _context;

        public EditModel(ScaleLibrary.Data.ScaleLibraryContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(GuitarScale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuitarScaleExists(GuitarScale.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool GuitarScaleExists(int id)
        {
            return _context.GuitarScale.Any(e => e.ID == id);
        }
    }
}
