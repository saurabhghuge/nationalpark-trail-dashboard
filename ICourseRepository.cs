using Eduvanz.Core.DTOs;
using Eduvanz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Eduvanz.Core.Interfaces.Infrastructure.Repository
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetCourses();
        Task<Course> GetCourse(int courseId);
        Task<int> AddCourse(Course course);
        Task<int> UpdateCourse(Course course);
        Task<int> DeleteCourse(int courseId);
    }
}
