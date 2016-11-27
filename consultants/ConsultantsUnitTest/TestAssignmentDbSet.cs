using consultants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantsUnitTest
{
    class TestAssignmentDbSet: TestDbSet<Details>
    {
        public override Details Find(params object[] keyValues)
        {
            return this.SingleOrDefault(ass => ass.Assignment_ID == (int)keyValues.Single());
        }

    }
}
