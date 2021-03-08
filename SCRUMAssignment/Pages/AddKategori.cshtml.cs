using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SCRUMAssignment.Models;
using SCRUMAssignment.Services;

namespace SCRUMAssignment.Pages
{
    public class AddKategoriModel : PageModel
    {
        [BindProperty]
        public Kategori Kategori { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Kategori.Emner = new Dictionary<int, Emne>();
            new KategoriHandler().Create(Kategori);
            return RedirectToPage("Index");
        }
    }
}
