using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Pages
{
    public class ViewerModel : PageModel
    {
        public Kategori Kategori { get; set; }

        public Emne Emne { get; set; }
        public void OnGet(int id)
        {
            Kategori = new Services.KategoriHandler().Get(id);
            
                Emne = Kategori.Emner[new Random().Next(0, Kategori.Emner.Count)];
            
            
        }
    }
}
