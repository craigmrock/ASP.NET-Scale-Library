using ScaleLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ScaleLibrary.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScaleLibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScaleLibraryContext>>()))
            {
                // Look for any scales
                if (context.GuitarScale.Any())
                {
                    return;   // DB has been seeded
                }
                //add these scales at startup
                context.GuitarScale.AddRange(
                    new GuitarScale
                    {
                        Name = "C Ionian",
                        Notes = "C - D - E - F - G - A - B",
                        Formula = "Major"
                    },

                    new GuitarScale
                    {
                        Name = "C Dorian",
                        Notes = "C - D - Eb - F - G - A - Bb",
                        Formula = "Flat 3rd, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "C Phrygian",
                        Notes = "C - Db - Eb - F - G - Ab - Bb",
                        Formula = "Flat 2nd, 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "C Lydian",
                        Notes = "C - D - E - F# - G - A - B",
                        Formula = "Sharp 4th"
                    },

                    new GuitarScale
                    {
                        Name = "C Mixoydian",
                        Notes = "C - D - E - F - G - A - Bb",
                        Formula = "Flat 7th"
                    },

                    new GuitarScale
                    {
                        Name = "C Aeolian",
                        Notes = "C - D - Eb - F - G - Ab - Bb",
                        Formula = "Flat 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "C Locrian",
                        Notes = "C - Db - Eb - F - Gb - Ab - Bb",
                        Formula = "Flat 2nd, 3rd, 5th, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "C Harmonic Minor",
                        Notes = "C - D - Eb - F - G - Ab - B",
                        Formula = "Flat 3rd, 6th"
                    },

                    new GuitarScale
                    {
                        Name = "G Ionian",
                        Notes = "G - A - B - C - D - E - F#",
                        Formula = "Major"
                    },

                    new GuitarScale
                    {
                        Name = "G Dorian",
                        Notes = "G - A - Bb - C - D - E - F",
                        Formula = "Flat 3rd, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "G Lydian",
                        Notes = "G - A - B - C# - D - E - F#",
                        Formula = "Sharp 4th"
                    },

                    new GuitarScale
                    {
                        Name = "G Mixoydian",
                        Notes = "G - A - B - C - D - E - F",
                        Formula = "Flat 7th"
                    },

                    new GuitarScale
                    {
                        Name = "G Aeolian",
                        Notes = "G - A - Bb - C - D - Eb - F",
                        Formula = "Flat 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "G Locrian",
                        Notes = "G - Ab - Bb - C - Db - Eb - F",
                        Formula = "Flat 2nd, 3rd, 5th, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "A Ionian",
                        Notes = "A - B - C#- D - E - F#- G#",
                        Formula = "Major"
                    },

                    new GuitarScale
                    {
                        Name = "A Dorian",
                        Notes = "A - B - C - D - E - F# - G",
                        Formula = "Flat 3rd, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "A Phrygian",
                        Notes = "A - Bb - C - D - E - F - G",
                        Formula = "Flat 2nd, 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "A Lydian",
                        Notes = "A - B - C#- D# - E - F#- G#",
                        Formula = "Sharp 4th"
                    },

                    new GuitarScale
                    {
                        Name = "A Mixoydian",
                        Notes = "A - B - C# - D - E - F# - G",
                        Formula = "Flat 7th"
                    },

                    new GuitarScale
                    {
                        Name = "A Aeolian",
                        Notes = "A - B - C - D - E - F - G",
                        Formula = "Flat 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "E Ionian",
                        Notes = "A - B - C#- D - E - F#- G#",
                        Formula = "Major"
                    },

                    new GuitarScale
                    {
                        Name = "E Dorian",
                        Notes = "A - B - C - D - E - F# - G",
                        Formula = "Flat 3rd, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "E Phrygian",
                        Notes = "E - F - G - A - B - C - D",
                        Formula = "Flat 2nd, 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "E Lydian",
                        Notes = "E - F# - G# - A# - B - C# - D#",
                        Formula = "Sharp 4th"
                    },

                    new GuitarScale
                    {
                        Name = "E Mixoydian",
                        Notes = "E - F# - G# - A - B - C# - D",
                        Formula = "Flat 7th"
                    },

                    new GuitarScale
                    {
                        Name = "E Aeolian",
                        Notes = "E - F# - G - A - B - C - D",
                        Formula = "Flat 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "E Locrian",
                        Notes = "E - F - G - A - Bb - C - D",
                        Formula = "Flat 2nd, 3rd, 5th, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "D Ionian",
                        Notes = "D - E - F# - G - A - B - C#",
                        Formula = "Major"
                    },

                    new GuitarScale
                    {
                        Name = "D Dorian",
                        Notes = "D - E - F - G - A - B - C",
                        Formula = "Flat 3rd, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "D Phrygian",
                        Notes = "D - Eb - F - G - A - Bb - C",
                        Formula = "Flat 2nd, 3rd, 6th, 7th"
                    },

                    new GuitarScale
                    {
                        Name = "D Lydian",
                        Notes = "D - E - F# - G# - A - B - C#",
                        Formula = "Sharp 4th"
                    },

                    new GuitarScale
                    {
                        Name = "D Mixoydian",
                        Notes = "D - E - F# - G - A - B - C",
                        Formula = "Flat 7th"
                    },

                    new GuitarScale
                    {
                        Name = "D Aeolian",
                        Notes = "D - E - F - G - A - Bb - C",
                        Formula = "Flat 3rd, 6th, 7th"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}