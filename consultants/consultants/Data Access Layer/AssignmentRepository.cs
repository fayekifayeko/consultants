using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consultants.Data_Access_Layer
{
    public class AssignmentRepository:IAssignmentRepository
    {
        private ConsoltantsContext db = new ConsoltantsContext();

        public IEnumerable<Assignment> GetAll()
        {
            return db.Assignments;
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
