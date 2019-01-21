﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestEntityFramework.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
    }
}