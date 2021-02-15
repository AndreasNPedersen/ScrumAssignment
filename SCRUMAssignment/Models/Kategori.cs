using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SCRUMAssignment.Models
{
    public class Kategori : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
