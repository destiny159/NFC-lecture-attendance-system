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
        public long TimeStamp {get;set;}
        [Required]
        public string StudId{get;set;}
    }
}
