﻿using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
        //public DbSet<Student> Students { get; set; }
    }
}
