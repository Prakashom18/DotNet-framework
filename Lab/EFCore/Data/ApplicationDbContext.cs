using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace EFCore.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
