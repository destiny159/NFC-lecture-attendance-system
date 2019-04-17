using System.ComponentModel.DataAnnotations;
namespace NFCSystem.Models
{
    public class UserList
    {
        public string UserName {get; set;}
        [Required]
        public string FirstName {get; set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        public string Group {get;set;}
        [Required]
        public long UID {get;set;}
        
    }
}