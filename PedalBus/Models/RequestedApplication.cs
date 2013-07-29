using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class RequestedApplication : Application
    {
        public int AccountId { get; set; }
        public string Outcome { get; set; }
        public string Justification { get; set; }
        public virtual ICollection<RequestedGroup> RequestedGroups { get; set; }
    }
}