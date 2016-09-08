using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("PeopleExperiencesJoins")]
    public class PeopleExperiencesJoin
    {
        [Key]
        public int JoinId { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }
    }
}
