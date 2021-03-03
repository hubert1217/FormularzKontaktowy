using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularzKontaktowy.Models
{
    public class Client
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public bool? Urgent { set; get; }
    }
}