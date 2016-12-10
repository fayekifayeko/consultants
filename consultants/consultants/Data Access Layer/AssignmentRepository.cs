using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

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
            Assignment assignment =  db.Assignments.FirstOrDefault(p => p.Assignment_ID == id);
           
            return assignment;        }
        public void Add(Assignment assignment)
        {
            db.Assignments.Add(assignment);
            db.SaveChanges();
        }

        public void delete(int assignment_Id)
        {
            var assignment = db.Assignments.FirstOrDefault(m => m.Assignment_ID == assignment_Id);
            db.Assignments.Remove(assignment);
           db.SaveChanges();
        }

        public void update(int assignment_Id, Assignment assignment)
        {
            var original = db.Assignments.FirstOrDefault(m => m.Assignment_ID == assignment.Assignment_ID);

            original.Assignment_Name = assignment.Assignment_Name;
            original.Client_Name =assignment.Client_Name;
            original.Comment = assignment.Comment;
            original.Consultant = assignment.Consultant;
            original.Consultant_ID = assignment.Consultant_ID;
            original.Start_Date = assignment.Start_Date;
            original.End_Date = assignment.End_Date;
            original.Percentage = assignment.Percentage;
            
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
