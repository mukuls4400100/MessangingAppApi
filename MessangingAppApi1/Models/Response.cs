using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessangingAppApi1.Models
{
    public class Response
    {
        public string Status { set; get; }
        public string Message { set; get; }

        public int userId { set; get; }
        public string name { set; get; }
    }
}