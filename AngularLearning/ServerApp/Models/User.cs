using System;
using Microsoft.AspNetCore.Identity;

namespace ServerApp.Models
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }

        public string Gender { get; set; } 

        public DateTime DateOfBirth { get; set; }

        public DateTime Created{ get; set; }

        public DateTime LastActive { get; set; }
    }
}