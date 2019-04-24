using System;
using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models.Timetable
{
    public class Period
    {
        public int PeriodId {get;set;}
        public TimeSpan PeriodStartTime {get;set;}
        public TimeSpan PeriodEndTime {get;set;}
    }
}