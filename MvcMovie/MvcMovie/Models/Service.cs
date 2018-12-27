using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Service
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}