using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Admin:User
    {
        public string Role { get; set; }
        public Admin(string name, string email, string role)
            :base(name,email)
        {
            Name = name;
            Email = email;
            Role = role;
        }
        
    }
}
