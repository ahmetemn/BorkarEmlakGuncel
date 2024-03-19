using BorkarEmlak.DATA.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BorkarEmlak.REPO.Context
{
    public  class ApplicationContext:IdentityDbContext<AppUser, AppRole, string>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer(@"Server=LAPTOP-12QQ6NC6\AHMET;Database=BorkarEmlak;Trusted_Connection=True;MultipleActiveResultSets=false;TrustServerCertificate=True;");


        }


        public DbSet<City>Cities { get; set; }  

        public DbSet<Emlak>Emlaks { get; set; } 
       public DbSet<Country> Countries { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<IdentityUserLogin<string>>().HasKey(p => p.UserId);

        }
    }
}
