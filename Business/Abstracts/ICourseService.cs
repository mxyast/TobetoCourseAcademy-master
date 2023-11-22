using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByCategoryId(int id);
        IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IDataResult<Course> GetById(int id); 

        IResult Add(Course course);

    }
}
