using System;
using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models
{
    public class NFCScan
    {
        [Required]
        [KeyAttribute]
        public long ScanID {get;set;}
        [Required]
        public long UID {get;set;}
        [Required]
        public DateTime TimeStamp {get;set;}
        [Required]
        public int DeviceID {get;set;}
    }
}
