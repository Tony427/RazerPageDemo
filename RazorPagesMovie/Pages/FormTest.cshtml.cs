using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class FormTestModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Now { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Now = DateTime.Now.ToString("HH:mm:ss");
        }

        public void OnPostEngGreet()
        {
            Message = $"Hello, {Name}";
        }

        public void OnPostChtGreet()
        {
            Message = $"{Name}, 您好";
        }
    }
}
