using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }
        public double Price { get; set; }
    }
}