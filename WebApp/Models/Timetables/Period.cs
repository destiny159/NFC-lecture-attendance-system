using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NFCSystem.Models.Timetables
{
    public class Period
    {
        public int PeriodId {get;set;}
        public TimeSpan PeriodStartTime {get;set;}
        public TimeSpan PeriodEndTime {get;set;}
        
        public ICollection<Timetable> Timetables {get;set;}
    }
}