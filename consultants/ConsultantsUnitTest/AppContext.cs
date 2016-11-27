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
    class AppContext : IAppContext

    {
        public AppContext()
        {
            this.Details = new TestAssignmentDbSet();
        }

        public DbSet<Details> Details { get; set; }

        public void Add(Assignment assignment)
        {
            throw new NotImplementedException();
        }

        public void Add(Details detail)
        {

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Details> GetAll()
        {
            return this.Details.ToList();
        }

        public IEnumerable<Consultant> GetAllDetails()
        {
            throw new NotImplementedException();
        }

        //public List<Details> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Consultant> GetAllDetails()
        //{
        //    throw new NotImplementedException();
        //}

        public Assignment GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
