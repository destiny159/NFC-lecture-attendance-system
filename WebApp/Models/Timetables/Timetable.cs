using System.Net.Mime;
using System;
using System.ComponentModel.DataAnnotations;
using NFCSystem.Models;
using NFCSystem.Models.Timetables;

namespace NFCSystem.Models.Timetables
{
    public class Timetable
    {
        public int TimetableId {get;set;}

        public string CourseId {get;set;}
        public Course Course {get;set;}

        public int PeriodId {get;set;}
        public Period Period {get;set;}

        public string StudentId {get;set;}
        public ApplicationUser ApplicationUser {get;set;}

        public int ClassroomId {get;set;}
        public Classroom Classroom {get;set;}

        public bool isVisited {get;set;}
    }
}