using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class AccountGroup
    {
        public int AccountID { get; set; }
        public int GroupID { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
        public DateTime LastModified { get; set; }
    }
}