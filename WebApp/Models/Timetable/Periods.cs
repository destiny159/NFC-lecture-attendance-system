using System;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models.Timetable
{
    public class Periods
    {
        public int ID {get;set;}
        public TimeSpan PeriodStartTime {get;set;}
        public TimeSpan PeriodEndTime {get;set;}

    }
}