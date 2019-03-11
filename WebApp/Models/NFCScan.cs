using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models
{
    public class NFCScan
    {
        public int UID {get;set;}
        [KeyAttribute]
        public long TimeStamp {get;set;}
    }
}