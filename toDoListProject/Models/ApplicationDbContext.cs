﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoListProject.Models
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<thingsToDo> thingsToDos { get; set; }

        public ApplicationDbContext() : base("toDoLists")
        {

        }
    }
}
