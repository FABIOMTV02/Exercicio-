using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorClassLibrary1.Areas.Relogio.Pages
{
    public class Index1Model : PageModel
    {
        public void OnGet()
        {
            TempData["Horario"] = DateTime.Now;
            TempData["Usuario"] = "Alan Berrola";
        }
    }
}
