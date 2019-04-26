using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using NFCSystem.Models.Timetables;
namespace NFCSystem.Models
{
    public class Device
    {
        public int DeviceId {get;set;}
        public int DeviceIdReal {get;set;}
        public int PendingDeviceId {get;set;}

        public bool updatePending {get;set;}

        public int ClassroomId {get;set;}
        public Classroom Classroom {get;set;}
    }
}