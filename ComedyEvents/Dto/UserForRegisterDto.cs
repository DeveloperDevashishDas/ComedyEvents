using System;
using System.ComponentModel.DataAnnotations;

namespace ComedyEvents.Dto
{
    public class UserForRegisterDto
    {
        //[Required]
        public string Username { get; set; }

        //[Required]
        //[StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public string Password { get; set; }

        //[Required]
        public string Gender { get; set; }

        public string Country { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}