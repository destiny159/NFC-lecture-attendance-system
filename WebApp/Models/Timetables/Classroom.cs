using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models.Timetables
{
    public class Classroom
    {
        public int ClassroomId {get;set;}
        public string ClassLabel {get;set;}
        public string ClassLocation {get;set;}

        public ICollection<Device> Devices {get;set;}
        public ICollection<Timetable> Timetables {get;set;}
    }
}