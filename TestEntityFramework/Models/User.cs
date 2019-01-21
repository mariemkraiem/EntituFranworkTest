using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestEntityFramework.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }

        public virtual List<Project> Projects { get; set; }
    }
}