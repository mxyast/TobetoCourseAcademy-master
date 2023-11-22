using Business.Concretes;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;


namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CourseManager courseManager = new CourseManager(new EfCourseDal());
            Test1(courseManager);
            Test2(courseManager);
            var result = courseManager.GetCourseDetails();
            if (result.Success==true)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.CourseName + "  /  " + course.CategoryName);
                }
                Console.WriteLine("-------------------------------");

            }
            else 
            {
                Console.WriteLine(result.Message); 
            }
        }

        private static void Test2(CourseManager courseManager)
        {
            foreach (var course in courseManager.GetCourseDetails().Data)
            {
                Console.WriteLine(course.CourseName + "  /  " + course.CategoryName);
            }
            Console.WriteLine("-------------------------------");
        }

        private static void Test1(CourseManager courseManager)
        {
            

            foreach (var course in courseManager.GetAllByCategoryId(1).Data)
            {
                Console.WriteLine(course.Name);
            }
            Console.WriteLine("-------------------------------");
            foreach (var course in courseManager.GetByUnitPrice(25, 50).Data)
            {
                Console.WriteLine(course.Name);
            }
            Console.WriteLine("-------------------------------");
            foreach (var course in courseManager.GetAll().Data)
            {
                Console.WriteLine(course.Name);
            }
            Console.WriteLine("-------------------------------");
        }
    }
}