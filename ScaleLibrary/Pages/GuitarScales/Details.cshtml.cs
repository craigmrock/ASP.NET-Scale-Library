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
    public class DetailsModel : PageModel
    {
        private readonly ScaleLibrary.Data.ScaleLibraryContext _context;

        public DetailsModel(ScaleLibrary.Data.ScaleLibraryContext context)
        {
            _context = context;
        }

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
    }
}
