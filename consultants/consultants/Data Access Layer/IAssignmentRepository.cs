using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace consultants.Data_Access_Layer
{
    public interface IAssignmentRepository
    {
        List<Details> GetAll();
        IEnumerable<Consultant> GetAllDetails();


        Assignment GetById(int id);
        void Add(Assignment assignment);
        void delete(int assignment_Id);
        void update(int assignment_Id,Assignment assignment);
    }
}