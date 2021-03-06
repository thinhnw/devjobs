using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devjobs.Dtos
{
    public class RegisterDto
    {        
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

     
        [Required]
        public string Password { get; set; }

        [Required]
        public bool IsCorporate { get; set; }
    }
}
