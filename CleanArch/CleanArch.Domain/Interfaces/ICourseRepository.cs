﻿using System.Collections.Generic;
using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
