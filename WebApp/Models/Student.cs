using System;
using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models
{
    public class Student
    {
        public int StudentId {get;set;}
        public Int64 UID { get; set; }
        public string Group { get; set; }
        public string StudentCode { get; set; }

        public ApplicationUser ApplicationUser {get;set;}
    }
}