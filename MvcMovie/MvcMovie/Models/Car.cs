using System.Collections.Generic;

namespace MvcMovie.Models
{
    public enum Make
    {
        BMW,
        MITSYBISHI,
        TESLA,
        SCION,
        KIA
    }

    public class Car
    {
        public int ID { get; set; }
        public string Vin { get; set; }
        public Make Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int ?Month { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}