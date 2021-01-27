using System.Collections.Generic;
using System.Linq;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repositories
{
    public class CoursesRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CoursesRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses.ToList();
        }
    }
}
