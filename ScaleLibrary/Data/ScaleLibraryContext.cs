using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScaleLibrary.Models;

namespace ScaleLibrary.Data
{
    public class ScaleLibraryContext : DbContext
    {
        
        public ScaleLibraryContext (DbContextOptions<ScaleLibraryContext> options)
            : base(options) //if this constructor isn't here it won't go to appsettings.json file to retrieve connection
        {
        }

        public DbSet<ScaleLibrary.Models.GuitarScale> GuitarScale { get; set; }

        
    }
}
