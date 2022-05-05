using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScaleLibrary.Data;
using ScaleLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

//.cshtml.cs files have C# code to handle page events

namespace ScaleLibrary.Pages.GuitarScales
{
    public class IndexModel : PageModel
    {
        private readonly ScaleLibrary.Data.ScaleLibraryContext _context;

        public IndexModel(ScaleLibrary.Data.ScaleLibraryContext context)
        {
            _context = context;
        }

        public IList<GuitarScale> GuitarScales { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)] //binds form values and query strings with the same name as the property and equired for binding on HTTP GET requests.
        public string MovieGenre { get; set; }


        public IList<GuitarScale> GuitarScale { get;set; }

        public async Task OnGetAsync()
        {
            //GuitarScale = await _context.GuitarScale.ToListAsync();
            IQueryable<string> notesQuery = from m in _context.GuitarScale
                                            orderby m.Notes
                                            select m.Notes;

            var guitarScales = from m in _context.GuitarScale
                              select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                guitarScales = guitarScales.Where(s => s.Name.Contains(SearchString));
            }
            
            GuitarScale = await guitarScales.ToListAsync();
        }
    }
}
