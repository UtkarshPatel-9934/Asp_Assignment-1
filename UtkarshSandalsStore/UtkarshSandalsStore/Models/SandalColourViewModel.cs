using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace UtkarshSandalsStore.Models
{
    public class SandalColourViewModel
    {
        // Created a code which adds a search functionality or filterng the data based on the colour name provided in the filter tab.
        public List<Sandal> Sandals { get; set; }
        public SelectList Colour { get; set; }
        public string SandalColour { get; set; }
        public string SearchString { get; set; }
    }
}
