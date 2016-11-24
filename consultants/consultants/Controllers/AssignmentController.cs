﻿using consultants.Data_Access_Layer;
using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Caching;

namespace consultants.Controllers

{
    public class AssignmentController: ApiController
    {
        private IAssignmentRepository _repository;
        IEnumerable<Assignment> My_Result;
        public AssignmentController(IAssignmentRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Assignment> Get()
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


           
            
            
                My_Result = ctx.Cache["CacheKey"] as IEnumerable<Assignment>;
            
            return My_Result;
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