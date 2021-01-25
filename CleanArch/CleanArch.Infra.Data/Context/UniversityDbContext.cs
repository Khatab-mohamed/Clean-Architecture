using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) :base (options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
