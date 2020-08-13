using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Dtos
{
    public class UserForLoginDto 
    {
        public string Username { get; set; }
      
        public string Password { get; set; }
    }
}
