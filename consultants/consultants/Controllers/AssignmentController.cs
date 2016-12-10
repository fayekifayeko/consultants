using consultants.Data_Access_Layer;
using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Caching;
using System.Web.Mvc;

namespace consultants.Controllers

{
    //[System.Web.Mvc.RequireHttps]
    //[RequireHttps]
    public class AssignmentController : ApiController
    {
        private IAssignmentRepository _repository;
        List<Details> My_Result;
        public AssignmentController(IAssignmentRepository repository)
        {
            _repository = repository;
        }
        public List<Details> Get()
        {

            var ctx = HttpContext.Current;
            if (ctx != null)
            {
                if (ctx.Cache["CacheKey"] == null)
                {
                    My_Result = _repository.GetAll();
                    ctx.Cache.Insert("CacheKey", My_Result, null,
          System.Web.Caching.Cache.NoAbsoluteExpiration,
          TimeSpan.FromMinutes(1));

                }

            }





            My_Result = ctx.Cache["CacheKey"] as List<Details>;

            return My_Result;
            //return _repository.GetAll();
        }

        public Assignment Get(int id)
        {
            var assignment = _repository.GetById(id);
            if (assignment == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return assignment;
        }
        [System.Web.Http.HttpPost]
        public HttpStatusCodeResult Post(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(assignment);
                return new HttpStatusCodeResult(200);


            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

        }
        [System.Web.Http.HttpPut]
        public HttpStatusCodeResult Put(int assignment_Id, Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                _repository.update(assignment_Id,assignment);
                return new HttpStatusCodeResult(200);


            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

        }
        [System.Web.Http.HttpDelete]
        HttpStatusCodeResult Delete(int assignment_Id)
        {
            try
            {
                _repository.delete(assignment_Id);
                return new HttpStatusCodeResult(200);

            }
            catch
            {
              throw new HttpResponseException(System.Net.HttpStatusCode.InternalServerError);

            }
        }

    }
}