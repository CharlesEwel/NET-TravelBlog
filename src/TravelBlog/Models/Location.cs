using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location

    {
        public Location()
        {
            Experiences = new List<Experience>();
            People = new List<Person>();
        }
        [Key]
        public int LocationId { get; set; }
        public string PlaceName { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Person> People { get; set; }

    }
}
