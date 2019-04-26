using System;
using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models
{
    public class NFCScan
    {
        public int ScanId {get;set;}
        public long UID {get;set;}
        public DateTime TimeStamp {get;set;}

        public int DeviceId {get;set;}
    }
}
