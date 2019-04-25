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
using Microsoft.Extensions.Identity.Core;


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
            builder.Entity<Classroom>().HasMany<Device>(g => g.Devices).WithOne(s => s.Classroom).HasForeignKey(s => s.ClassroomId);
            #if NEW_DB
            builder.Entity<Classroom>().HasData(new Classroom{ClassroomId=9999, ClassLabel="DummmyClassroom",ClassLocation="Moon, in a far galaxy away"});
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

            //Configuration for Device
            builder.Entity<Device>().HasKey(k => k.DeviceId);
            builder.Entity<Device>().Property(p => p.DeviceId).ValueGeneratedOnAdd();
            builder.Entity<Device>().Property(p => p.ClassroomId).HasDefaultValue(9999);
            //builder.Entity<Device>().HasOne<Classroom>(p => p.Classroom).WithMany(d => d.Devices).HasForeignKey<>(s => s.ClassroomId).OnDelete(DeleteBehavior.SetNull);
            builder.Entity<Device>().HasData(new Device{DeviceId=1,DeviceIdReal=1, ClassroomId=3});
            builder.Entity<Device>().HasData(new Device{DeviceId=2,DeviceIdReal=2, ClassroomId=5});
            builder.Entity<Device>().HasData(new Device{DeviceId=3,DeviceIdReal=3, ClassroomId=13});
            builder.Entity<Device>().HasData(new Device{DeviceId=4,DeviceIdReal=4, ClassroomId=9999});
            builder.Entity<Device>().HasData(new Device{DeviceId=5,DeviceIdReal=5, ClassroomId=9999});
            builder.Entity<Device>().HasData(new Device{DeviceId=6,DeviceIdReal=6, ClassroomId=9999});

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

            // Create seed users
            var rnd = new Random();
            var hasher = new PasswordHasher<ApplicationUser>();

            for(int i = 1; i <= 100; i++)
            {
                string username = "varpav" + i.ToString("D3");
                string name = "Vardas" + i.ToString("D3");
                string surname = "Pavarde" + i.ToString("D3");; 
                string email = name + "." + surname + i.ToString("D3") + "@email.com";
                int uid = 100000000 + rnd.Next(1,99999999);
                string group = string.Format("IFF-{0}/{1}", rnd.Next(1,10), rnd.Next(1,10));
                string userId = "a18be9c0-aa65-4af8-bd17-00bd9344" + i.ToString("D4"); // Need 4 more chars

                builder.Entity<ApplicationUser>().HasData(new ApplicationUser
                {
                    Id = userId,
                    UserName = username,
                    NormalizedUserName = username.ToUpper(),
                    Name = name,
                    Surname = surname,
                    Email = email,
                    NormalizedEmail = email.ToUpper(),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UID = uid,
                    Group = group,
                    StudentCode = "C" + i.ToString("D5"),
                    PasswordHash = hasher.HashPassword(null, "Admin123++"),
                });

                builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = "STUDENT",
                    UserId = userId
                });
            }

            base.OnModelCreating(builder);
        }
    }
}

