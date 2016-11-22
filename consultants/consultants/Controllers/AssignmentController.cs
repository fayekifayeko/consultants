using consultants.Data_Access_Layer;
using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace consultants.Controllers

{
    public class AssignmentController: ApiController
    {
        private IAssignmentRepository _repository;

        public AssignmentController(IAssignmentRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Assignment> Get()
        {
            return _repository.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var assignment = _repository.GetById(id);
            if (assignment == null)
            {
                return NotFound();
            }
            return Ok(assignment);
        }

    }
}