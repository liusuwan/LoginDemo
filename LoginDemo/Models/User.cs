using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginDemo.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public virtual Role Role { get; set; }
    }
}