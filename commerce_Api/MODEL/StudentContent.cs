using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commerce_Api.MODEL
{
    public class StudentContent : DbContext
    {
        public StudentContent() { }
        public StudentContent(DbContextOptions<StudentContent> options) : base(options) { }

        public DbSet<Student> students { get; set; }
    }
}
