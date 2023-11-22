﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Course> Courses { get; set; } //Hangi nesnem hangi nesneye karşılık gelicek//hangi classım hangi tabloya karşılık
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructores { get; set; }
      
    }
}
