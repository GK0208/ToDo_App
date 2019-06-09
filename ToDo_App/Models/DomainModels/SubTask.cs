﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo_App.Models.DomainModels
{
    public class SubTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
        public bool Done { get; set; }
    }
}
