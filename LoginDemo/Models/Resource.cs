using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginDemo.Models
{
    public class Resource
    {
        public string ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}