using System;
using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models.Timetable
{
    public class Course
    {
        public enum CourseType
        {
            Lab,
            Theory,
            Practice
        }

        public int ID {get;set;}
        public int CourseName {get;set;}
    }
}