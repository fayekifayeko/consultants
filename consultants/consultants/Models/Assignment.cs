using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace consultants.Models
{
    public class Assignment
    {
        [Key]
        public int Assignment_ID { get; set; }
        public string Assignment_Name { get; set; }

        public string Client_Name { get; set; }
        public string Percentage { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Comment { get; set; }
        public int Consultant_ID { get; set; }

        public virtual Consultant Consultant { get; set; }
    }
}