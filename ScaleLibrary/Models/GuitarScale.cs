using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ScaleLibrary.Models
{
    public class GuitarScale
    {
        public int ID { get; set; } //required by the database for the primary key

        [StringLength(60, MinimumLength = 1)]
        [Required] //validation for required field and minimum length, although this program does not allow user to create new items for the database.
        public string Name { get; set; }

        public string Notes { get; set; }
        public string Formula { get; set; }
    }
}
