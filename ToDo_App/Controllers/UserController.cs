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
        public UserController()
        {
            _tasks = new List<Task>()
            {
                new Task()
                {
                   Title="Homework",
                   Description="Description",
                   Importance=Importance.Important,
                   Status=Status.Done,
                   Type=Models.DomainModels.Type.Work,
                   SubTasks=new List<SubTask>()
                   {
                      new SubTask()
                      {
                            Title="Learn MVC",
                            Description="Description",
                            Done=true
                      },
                      new SubTask()
                      {
                            Title="Make MVC Application",
                            Description="Description",
                            Done=true
                      }
                   }
                },
                new Task()
                {
                   Title="Sport",
                   Description="Description",
                   Importance=Importance.MediumImportance,
                   Status=Status.NotDone,
                   Type=Models.DomainModels.Type.Hoby,
                   SubTasks=new List<SubTask>()
                   {
                        new SubTask()
                        {
                                Title="Football",
                                Description="Description",
                               Done=true
                        },
                        new SubTask()
                        {
                                Title="Basketball",
                                Description="description",
                                Done=false
                        },
                   }
                },
                new Task()
                {
                   Title="Work",
                   Description="Description",
                   Importance=Importance.Important,
                   Status=Status.Done,
                   Type=Models.DomainModels.Type.Work,
                   SubTasks=new List<SubTask>()
                   {
                       new SubTask()
                       {
                            Title="Make React Project",
                            Description="Description",
                            Done=true
                       }
                   }
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
            User goce = new User()
            {
                FirstName = "Goce",
                LastName = "Kabov",
                Age = 26,
                Email = "goce@yahoo.com",
                Password = "12345",
                FreeTime = 10.5M,
                Tasks = _tasks
            };

            return View(goce);
        }
        public IActionResult InProgress()
        {
            User goce = new User()
            {
                FirstName = "Goce",
                LastName = "Kabov",
                Age = 26,
                Email = "goce@yahoo.com",
                Password = "12345",
                FreeTime = 10.5M,
                Tasks = _tasks
            };

            return View(goce);
        }
        public IActionResult NotDone()
        {
            User goce = new User()
            {
                FirstName = "Goce",
                LastName = "Kabov",
                Age = 26,
                Email = "goce@yahoo.com",
                Password = "12345",
                FreeTime = 10.5M,
                Tasks = _tasks
            };

            return View(goce);
        }
       
        public IActionResult CreateTask()
        {
            return View();
        }
    }
}