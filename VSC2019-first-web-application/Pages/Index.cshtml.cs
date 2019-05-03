﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VSC2019_first_web_application.Pages
{
    public class IndexModel : PageModel
    {
         public string Time { get; set; }
        public void OnGet()
        {
            Time = DateTime.Now.ToShortTimeString();
        }
    }
}