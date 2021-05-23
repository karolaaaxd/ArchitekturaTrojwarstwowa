using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ASP.NET_CoreWebApplicationPage.Models;

namespace ASP.NET_CoreWebApplicationPage.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASP.NET_CoreWebApplicationPage.Models.Recenzja> Recenzja { get; set; }
        public DbSet<ASP.NET_CoreWebApplicationPage.Models.ProjectRole> ProjectRole { get; set; }
        public DbSet<ASP.NET_CoreWebApplicationPage.Models.Forum> Forum { get; set; }
    }
}
