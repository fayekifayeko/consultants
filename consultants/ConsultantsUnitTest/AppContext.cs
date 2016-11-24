using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using consultants.Models;
using consultants.Data_Access_Layer;

namespace ConsultantsUnitTest
{
    class AppContext : IAssignmentRepository

    {
        public AppContext()
        {
            this.Assignments = new TestAssignmentDbSet();
        }

        public DbSet<Assignment> Assignments { get; set; }

        public void Add(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Assignment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Assignment GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
