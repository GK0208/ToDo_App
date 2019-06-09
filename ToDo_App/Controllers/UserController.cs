using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo_App.Models.DomainModels;
using Task = ToDo_App.Models.DomainModels.Task;

namespace ToDo_App.Controllers
{
    [Route("User/[action]")]
    public class UserController : Controller
    {
        private List<Task> _tasks;
        private List<User> _users;
        public UserController()
        {
            _tasks = new List<Task>()
            {
                new Task()
                {
                   Title="Homework",
                   Description="Description",
                   Importance=Importance.Important,
                   Status=Status.NotDone,
                   Type=Models.DomainModels.Type.Work,

                },
                new Task()
                {
                   Title="Sport",
                   Description="Description",
                   Importance=Importance.MediumImportance,
                   Status=Status.NotDone,
                   Type=Models.DomainModels.Type.Hoby,
                },
                new Task()
                {
                   Title="Work",
                   Description="Description",
                   Importance=Importance.Important,
                   Status=Status.NotDone,
                   Type=Models.DomainModels.Type.Work,
                }
            };

            _users = new List<User>()
            {
            new User()
            {
                Id = 1,
                FirstName = "Goce",
                LastName = "Kabov",
                Age = 26,
                Email = "goce@yahoo.com",
                Password = "12345",
                FreeTime = 10.5M,
                Tasks = _tasks
            },
             new User()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                Age = 27,
                Email = "john@yahoo.com",
                Password = "1231231",
                FreeTime = 10.5M,
                Tasks = _tasks
            }
        };

        }
        public IActionResult Index(int? id)
        {
            return View();         
        }
        public IActionResult Statistic()
        {
            return View();
        }
        public IActionResult DoneTasks()
        {
            User goce = _users[0];

            return View(goce);
        }
        public IActionResult InProgress()
        {
            User goce = _users[0];

            return View(goce);
        }
        public IActionResult NotDone()
        {
            User goce = _users[0];

            return View(goce);
        }
       
        public IActionResult CreateTask()
        {
            return View();
        }
    }
}