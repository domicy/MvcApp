using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Activity
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public int Odometer { get; set; }
    }
}