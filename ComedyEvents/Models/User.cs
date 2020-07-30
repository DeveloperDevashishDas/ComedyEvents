﻿using System;
using Microsoft.AspNetCore.Identity;

namespace ComedyEvents.Models
{
    public class User

    {
        
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Gender { get; set; }
       
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Country { get; set; }

    }
}