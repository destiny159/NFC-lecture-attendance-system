using System;
using System.ComponentModel.DataAnnotations;
using NFCSystem.Models.Timetables;
using System.Collections.Generic;

namespace NFCSystem.Models.Timetables
{
    public class Course
    {
        public string CourseId {get;set;}
        public string CourseName {get;set;}

        public ICollection<Timetable> Timetables {get;set;}
    }
}