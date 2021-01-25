using System.Collections.Generic;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
