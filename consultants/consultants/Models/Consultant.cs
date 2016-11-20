using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consultants.Models
{
    public class Consultant
    {
        public int Consultant_ID { get; set; }
        public string Name { get; set; }
       
        public virtual ICollection<Assignment> Enrollments { get; set; }
    }
}