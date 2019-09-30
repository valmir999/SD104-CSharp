using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMVC_Quiz.Models;

namespace WebAppMVC_Quiz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppMVC_Quiz.Models.Employee> Employee { get; set; }
        public DbSet<WebAppMVC_Quiz.Models.Department> Department { get; set; }
    }
}
