using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consultants.Data_Access_Layer
{
    public interface IAssignmentRepository
    {
        IEnumerable<Assignment> GetAll();
        IEnumerable<Consultant> GetAllDetails();


        Assignment GetById(int id);
        void Add(Assignment assignment);
    }
}