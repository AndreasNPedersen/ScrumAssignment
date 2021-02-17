using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SCRUMAssignment.Pages.Shared
{
    public class EmneModel : PageModel
    {

        public Dictionary<int, Models.Kategori> Liste { get; set; }

        public EmneModel()
        {
            
        }
        public void OnGet()
        {
            Liste = new Services.KategoriHandler().GetDictionary();
        }
    }
}
