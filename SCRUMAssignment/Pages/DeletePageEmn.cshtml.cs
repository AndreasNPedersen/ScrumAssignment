using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Pages
{
    public class DeletePageEmnModel : PageModel
    {
        [BindProperty]
        public Models.Emne Emne { get; set; }
        [BindProperty]
        public Models.Kategori Kategori { get; set; }


        public void OnGet(int id)
        {
            
            foreach (Kategori kat in new Services.KategoriHandler().GetDictionary().Values)
            {
                if (kat.Emner.ContainsKey(id))
                {
                Emne = kat.Emner[id];
                    Kategori = kat;
                }
            }
            
        }

        public IActionResult OnPost()
        {
            Kategori kat = new Services.KategoriHandler().Get(Kategori.Id);
            kat.Emner.Remove(Emne.Id);
            new Services.KategoriHandler().Update(kat, kat.Id);
            return RedirectToPage("Index");
        }
    }
}
