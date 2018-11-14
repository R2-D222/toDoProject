using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoListProject.Models
{
    public class User
    {
        public string Name { get; set; }
        public string ForName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public thingsToDo thingsToDo { get; set; }

    }
}
