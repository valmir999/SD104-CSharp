using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationMusicStore2.Models;

namespace WebApplicationMusicStore2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identify model and override the defaults if needed.
            // For example, you can rename the ASP.NET identify table names and more.
            // Add your customizations after calling base.OnModelCreating(builder).
        }

        public DbSet<WebApplicationMusicStore2.Models.Music> Music { get; set; }
        public DbSet<WebApplicationMusicStore2.Models.Song> Song { get; set; }
    }
}
