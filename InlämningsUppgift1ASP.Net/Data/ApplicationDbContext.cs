using InlämningsUppgift1ASP.Net.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsUppgift1ASP.Net.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolClassesModel> Classes { get; set; }

        public DbSet<InlämningsUppgift1ASP.Net.Models.StudentModel> StudentModel { get; set; }

    }
}
