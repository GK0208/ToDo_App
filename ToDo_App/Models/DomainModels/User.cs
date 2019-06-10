using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models.DomainModels
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal FreeTime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
