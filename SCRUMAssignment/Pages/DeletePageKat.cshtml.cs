using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SCRUMAssignment.Pages
{
    public class DeletePageKatModel : PageModel
    {
        public Models.Kategori Kategori { get; set; }
        public void OnGet(int id)
        {
            Kategori = new Services.KategoriHandler().Get(id);
        }

        public IActionResult OnPost()
        {
            new Services.KategoriHandler().Delete(Kategori.Id);
            return RedirectToPage("Index");
        }
    }
}
