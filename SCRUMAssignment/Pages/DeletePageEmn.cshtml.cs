using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SCRUMAssignment.Pages
{
    public class DeletePageEmnModel : PageModel
    {
        [BindProperty]
        public Models.Emne Emne { get; set; }
        [BindProperty]
        public Models.Kategori Kategori { get; set; }
        public void OnGet(int idEmne,int idKat)
        {
            
            Kategori = new Services.KategoriHandler().Get(idKat);
            Emne = Kategori.Emner[idEmne];
        }

        public IActionResult OnPost()
        {
            Kategori = new Services.KategoriHandler().Get(Kategori.Id);
            Kategori.Emner.Remove(Emne.Id);
            new Services.KategoriHandler().Update(Kategori, Kategori.Id);
            return RedirectToPage("Index");
        }
    }
}
