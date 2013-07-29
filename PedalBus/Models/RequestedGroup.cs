using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class RequestedGroup : Group
    {
        public int AccountGroupId { get; set; }
        public string Outcome { get; set; }
    }
}