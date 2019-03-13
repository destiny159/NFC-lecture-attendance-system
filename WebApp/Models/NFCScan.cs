using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models
{
    public class NFCScan
    {
        public long UID {get;set;}
        [KeyAttribute]
        public long TimeStamp {get;set;}
        public string DateTime {get;set;}
    }
}