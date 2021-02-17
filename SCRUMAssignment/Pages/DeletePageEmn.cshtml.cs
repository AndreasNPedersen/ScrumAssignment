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
        public void OnGet(int id)
        {
            Emne = new Services.EmneHandler().Get(id);
        }

        public IActionResult OnPost()
        {
            new Services.EmneHandler().Delete(Emne.Id);
            return RedirectToPage("Index");
        }
    }
}
