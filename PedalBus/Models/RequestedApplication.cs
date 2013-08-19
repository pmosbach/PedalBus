using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class RequestedApplication
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int MatchedAccountId { get; set; }
        public int ApplicationId { get; set; }
        public string Outcome { get; set; }
        public string Justification { get; set; }
        public virtual Account CurrentAccount { get; set; }
        public virtual Account MatchedAccount { get; set; }
        public virtual Application CurrentApplication { get; set; }
        public virtual ICollection<RequestedGroup> RequestedGroups { get; set; }
    }
}