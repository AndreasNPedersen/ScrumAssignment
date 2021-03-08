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
    public class AddEmneModel : PageModel
    {
        [BindProperty]
        public Emne Emne { get; set; }
        
        public Dictionary<int,Models.Kategori> Kategori { get; set; }
        public void OnGet()
        {
            Kategori = new Services.KategoriHandler().GetDictionary();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            

            int hej = Convert.ToInt32(Request.Form["listkat"]);
            Models.Kategori kat = new Services.KategoriHandler().Get(hej);
            kat.Emner.Add(Emne.Id,Emne);
            new KategoriHandler().Update(kat, kat.Id);



            return RedirectToPage("Index");
        }
    }
}
