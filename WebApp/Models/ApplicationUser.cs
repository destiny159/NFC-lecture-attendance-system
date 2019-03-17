using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace NFCSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string StudentCode { get; set; }
    }
}
