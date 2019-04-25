using System;
using System.ComponentModel.DataAnnotations;
using NFCSystem.Models.Timetable;
namespace NFCSystem.Models
{
    public class Device
    {
        public int DeviceId {get;set;}
        public int DeviceIdReal {get;set;}

        public int ClassroomId {get;set;}
        public Classroom Classroom {get;set;}
    }
}