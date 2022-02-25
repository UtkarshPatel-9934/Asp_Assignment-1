using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtkarshSandalsStore.Models
{
    public class Sandal
    {
        //Added a Properties for my Product such as. ArtNumber, CompnyName, Colour, Material, Size, Price, Ratings.
        // Restrict the user to put the dummy data or mislead information using the constraints or by seting particular range of each property.
            public int Id { get; set; }
            [Display(Name = "Art Number")]
            [Range(1, 1000)]
            public int ArtNumber { get; set; }
            [Display(Name = "Company Name")]
            [StringLength(50, MinimumLength = 1)]
            public string CompanyName { get; set; }
            [StringLength(50, MinimumLength = 2)]
            public string Colour { get; set; }
            [StringLength(50, MinimumLength = 4)]

            public string Material { get; set; }
            [Range(1,12)]
            public int Size { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal Price { get; set; }
            [Range(1,5)]
            public int Ratings { get; set; }
    }
}
