using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo_App.Models.DomainModels;
using Task = ToDo_App.Models.DomainModels.Task;

namespace ToDo_App.Controllers

{   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {          
            return View();
        }
    }
}
