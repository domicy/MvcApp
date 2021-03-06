﻿using System.Data.Entity;
using MvcMovie.Models;

namespace MvcMovie.DataAccess
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("MovieDBContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}