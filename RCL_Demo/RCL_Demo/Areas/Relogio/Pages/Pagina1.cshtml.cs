using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RCL_Demo.Areas.Relogio.Pages
{
    public class Pagina1Model : PageModel
    {
        public void OnGet()
        {
            TempData["Horario"] = DateTime.Now;
            TempData["Usuario"] = "allgamestupra";
        }
    }
}
