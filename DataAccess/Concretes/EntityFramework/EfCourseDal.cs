using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet 
    public class EfCourseDal : EfEntityRepositoryBase<Course, NorthwindContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from co in context.Courses
                             join ca in context.Categories
                             on co.CategoryId equals ca.CategoryId
                             select new CourseDetailDto
                             {
                                 CategoryName = ca.CategoryName,
                                 CourseName = co.Name,
                                 CourseId = co.Id,
                                 UnitPrice = co.UnitPrice
                             };
                return result.ToList();
            }
        }
    }
}