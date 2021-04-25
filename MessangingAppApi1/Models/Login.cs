﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessangingAppApi1.Models
{
    public class Login
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Region { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}