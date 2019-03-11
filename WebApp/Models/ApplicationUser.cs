using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace NFCSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int UID {get;set;}
        public string Name {get;set;}
        public string Surname {get;set;}
        public string StudentCode {get;set;}
    }
}