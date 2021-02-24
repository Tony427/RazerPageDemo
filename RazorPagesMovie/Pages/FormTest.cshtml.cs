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
        public string Now => DateTime.Now.ToString("HH:mm:ss");
        public string Message => $"{HelloPrefix}{Name}";
        public string HelloPrefix { get; set; }

        public void OnGet()
        {
        }

        public void OnPostEngGreet()
        {
            HelloPrefix = "Hello, ";
        }

        //跟同步方法只能有一個
        //public async Task OnPostEngGreetAsync()
        //{
        //    HelloPrefix = "HelloAsync, ";
        //}

        public void OnPostChtGreet()
        {
            HelloPrefix = "您好, ";
        }
    }
}
