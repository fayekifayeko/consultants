using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consultants.Data_Access_Layer
{
    public class AppContext:IAssignmentRepository
    {
        private ConsoltantsContext db = new ConsoltantsContext();

        public IEnumerable<Consultant> GetAllDetails()
        {

            return db.Consultants.Include("Assignments");
                
                }

        public List<Details> GetAll()
        {
            return db.Assignments.Select(assgn => new Details
            {
                Assignment_ID = assgn.Assignment_ID,
                Assignment_Name = assgn.Assignment_Name,
                Client_Name = assgn.Client_Name,
                Percentage = assgn.Percentage,
                Start_Date = assgn.Start_Date,
                End_Date = assgn.End_Date,
                Comment = assgn.Comment,
                Consultant_Name = assgn.Consultant.Name,
                Is_Deadline = System.Data.Entity.DbFunctions.DiffDays(DateTime.Now,assgn.End_Date) < 30 ? true : false 
            }).ToList();
        }
        public Assignment GetById(int id)
        {
            return db.Assignments.FirstOrDefault(p => p.Assignment_ID == id);
        }
        public void Add(Assignment assignment)
        {
            db.Assignments.Add(assignment);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
