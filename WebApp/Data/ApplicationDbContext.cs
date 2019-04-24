#define NEW_DB

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pomelo.EntityFrameworkCore.MySql;
using NFCSystem.Models;
using NFCSystem.Models.Timetable;


namespace NFCSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<NFCScan> NFCScans { get; set; }
        public DbSet<Device> Devices {get;set;}
        public DbSet<Period> Periods {get;set;}
        public DbSet<Course> Courses {get;set;}
        public DbSet<Classroom> Classrooms {get;set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configuration for Periods
            builder.Entity<Period>().HasKey(k => k.PeriodId);
            #if NEW_DB
            builder.Entity<Period>().HasData(new Period{PeriodId=1, PeriodStartTime=new TimeSpan(9,0,0), PeriodEndTime=new TimeSpan(10,30,0)});
            builder.Entity<Period>().HasData(new Period{PeriodId=2, PeriodStartTime=new TimeSpan(11,0,0), PeriodEndTime=new TimeSpan(12,30,0)});
            builder.Entity<Period>().HasData(new Period{PeriodId=3, PeriodStartTime=new TimeSpan(13,30,0), PeriodEndTime=new TimeSpan(15,00,0)});
            builder.Entity<Period>().HasData(new Period{PeriodId=4, PeriodStartTime=new TimeSpan(15,30,0), PeriodEndTime=new TimeSpan(17,00,0)});
            builder.Entity<Period>().HasData(new Period{PeriodId=5, PeriodStartTime=new TimeSpan(17,30,0), PeriodEndTime=new TimeSpan(19,00,0)});
            #endif
            // Configuration for Courses
            builder.Entity<Course>().HasKey(k => k.CourseId);
            #if NEW_DB
            builder.Entity<Course>().HasData(new Course{CourseId="PB0000",CourseName="Algoritmų analizė ir sudarymas"});
            builder.Entity<Course>().HasData(new Course{CourseId="PB0001",CourseName="Duomenų bazės"});
            builder.Entity<Course>().HasData(new Course{CourseId="PB0002",CourseName="Semestro projektas"});
            builder.Entity<Course>().HasData(new Course{CourseId="PB0003",CourseName="Programų sistemų inžinerija"});
            builder.Entity<Course>().HasData(new Course{CourseId="PB0004",CourseName="Programavimo kalbų teorija"});
            builder.Entity<Course>().HasData(new Course{CourseId="PB0005",CourseName="Anglų kalba"});
            #endif

            //Configuration for Classrooms
            builder.Entity<Classroom>().HasKey(k => k.ClassroomId);
            #if NEW_DB
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=1, ClassLabel="101",ClassLocation="XI"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=2, ClassLabel="102",ClassLocation="XI"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=3, ClassLabel="103",ClassLocation="XI"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=4, ClassLabel="518",ClassLocation="XI"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=5, ClassLabel="215",ClassLocation="XI"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=6, ClassLabel="150",ClassLocation="XII"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=7, ClassLabel="151",ClassLocation="XII"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=9, ClassLabel="152",ClassLocation="XII"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=10, ClassLabel="153",ClassLocation="XII"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=11, ClassLabel="103AB",ClassLocation="IX"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=12, ClassLabel="103CD",ClassLocation="IX"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=13, ClassLabel="103KL",ClassLocation="IX"});
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=14, ClassLabel="108",ClassLocation="B2"});
            #endif

            // Configuration for Students
            builder.Entity<Student>().HasKey(k => k.StudentId);
            builder.Entity<Student>().HasOne<ApplicationUser>(u => u.ApplicationUser).WithOne(s => s.Student).HasForeignKey<ApplicationUser>(s => s.StudentId);

            // Configuration for Identity framework
            builder.Entity<ApplicationUser>(entity => {
                entity.Property(m => m.Email).HasMaxLength(127);
                entity.Property(m => m.NormalizedEmail).HasMaxLength(127);
                entity.Property(m => m.NormalizedUserName).HasMaxLength(127);
                entity.Property(m => m.UserName).HasMaxLength(127);
            });

            // Configure Roles and its fields
            builder.Entity<IdentityRole>(entity => {
                entity.Property(m => m.Name).HasMaxLength(127);
                entity.Property(m => m.NormalizedName).HasMaxLength(127);
            });
            #if NEW_DB
            builder.Entity<IdentityRole>().HasData(new IdentityRole{Id="STUDENT", Name="STUDENT",NormalizedName="STUDENT"});
            builder.Entity<IdentityRole>().HasData(new IdentityRole{Id="ADMIN", Name="ADMIN",NormalizedName="ADMIN"});
            builder.Entity<IdentityRole>().HasData(new IdentityRole{Id="LECTURER", Name="LECTURER",NormalizedName="LECTURER"});
            #endif

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.Property(m => m.LoginProvider).HasMaxLength(127);
                entity.Property(m => m.ProviderKey).HasMaxLength(127);
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.Property(m => m.UserId).HasMaxLength(127);
                entity.Property(m => m.RoleId).HasMaxLength(127);
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.Property(m => m.UserId).HasMaxLength(127);
                entity.Property(m => m.LoginProvider).HasMaxLength(127);
                entity.Property(m => m.Name).HasMaxLength(127);

            });
            base.OnModelCreating(builder);
        }
    }
}

