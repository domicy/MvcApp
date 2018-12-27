using MvcMovie.Models;
using System;
using System.Collections.Generic;

namespace MvcMovie.DataAccess
{
    public class GarageInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            var cars = new List<Car>
            {
                new Car{Vin = "wbawd51080pw18617", Make = Make.BMW ,Model = "330d (E92)", Year = 2007},
                new Car{Vin = null, Make = Make.BMW, Model = "330d (E46)", Year = 2000},
                new Car{Vin= "WBAFU7C55BC780638", Make = Make.BMW ,Model= "535xi (F10)", Year = 2007},
                new Car{Vin= null, Make = Make.MITSYBISHI, Model="ECLIPSE", Year = 1995},
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();

            var services = new List<Service>
            {
                new Service{ID = 1, Name = "eServisas" },
                new Service{ID = 2, Name = "Toptis" },
            };

            services.ForEach(s => context.Services.Add(s));
            context.SaveChanges();

            var activities = new List<Activity>
            {
                new Activity{CarId = 1, ServiceId = 1, Date = DateTime.Parse("2005-09-01"), Description = "Some text"},
                new Activity{CarId = 1, ServiceId = 2, Date = DateTime.Parse("2005-09-01"), Description = "Some text"},
                new Activity{CarId = 2, ServiceId = 1, Date = DateTime.Parse("2005-09-01"), Description = "Some text"},
                new Activity{CarId = 2, ServiceId = 2, Date = DateTime.Parse("2005-09-01"), Description = "Some text"},
                new Activity{CarId = 2, ServiceId = 2, Date = DateTime.Parse("2005-09-01"), Description = "Some text"},
            };

            activities.ForEach(a => context.Activities.Add(a));
            context.SaveChanges();
        }
    }
}