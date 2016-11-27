using consultants.Data_Access_Layer;
using consultants.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultantsUnitTest
{
    public interface IAppContext : IDisposable,IAssignmentRepository

    {
        DbSet<Details> Details { get; }

    }
}
