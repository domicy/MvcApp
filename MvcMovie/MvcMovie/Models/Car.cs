using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int ?Month { get; set; }
        public double Price { get; set; }

        public virtual List<Activity> Maintenances { get; set; }
    }
}