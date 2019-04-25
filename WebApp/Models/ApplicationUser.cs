using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NFCSystem.Data;
using NFCSystem.Models.Timetables;

namespace NFCSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Int64 UID { get; set; }
        public string Group { get; set; }
        public string StudentCode { get; set; }

        public ICollection<Timetable> Timetables {get;set;}
    }
}
