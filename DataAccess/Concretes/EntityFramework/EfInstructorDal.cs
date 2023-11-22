using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet 
    public class EfInstructorDal : EfEntityRepositoryBase<Instructor,NorthwindContext>, IInstructorDal
    {
    
    }
}