using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace consultants.Models
{
    public class Consultant
    {
        [Key]
        public int Consultant_ID { get; set; }
        public string Name { get; set; }
       
        public virtual ICollection<Assignment> Enrollments { get; set; }
    }
}