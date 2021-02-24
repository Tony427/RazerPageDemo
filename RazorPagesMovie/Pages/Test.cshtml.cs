using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages
{
    public class TestModel : PageModel
    {
        public string Description { get; set; }
        public TestModel()
        {
            Description = "This is test page";
        }
        public void OnGet()
        {
        }
    }
}
