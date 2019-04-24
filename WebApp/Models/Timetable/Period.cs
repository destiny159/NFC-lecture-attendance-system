using System;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models.Timetable
{
    public class Period
    {
        public int PeriodId {get;set;}
        public TimeSpan PeriodStartTime {get;set;}
        public TimeSpan PeriodEndTime {get;set;}
    }
}