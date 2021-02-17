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
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

               new EmneHandler().Create(Emne);
            }
            return RedirectToPage("Index");
        }
    }
}
