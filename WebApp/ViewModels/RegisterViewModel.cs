using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NFCSystem.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public Int64 UID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string StudentCode { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }    //varpav

        [Required]
        public string Password { get; set; }
    }

}
