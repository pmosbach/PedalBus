using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class RequestFlow
    {
        public int Id { get; set; }
        public int RequestorId { get; set; }
        public int SubmitterId { get; set; }
        public string RequestClass { get; set; }
        public string FurthestStep { get; set; }
        public bool AgreedToSOR { get; set; }
        public bool RequestPrivileged { get; set; }
        public bool ChangedEmployer { get; set; }
        public bool ChangedName { get; set; }
        public int MatchingPersonId { get; set; }
        public string LocalityFilter { get; set; }
        public virtual ICollection<RequestedApplication> RequestedApplications { get; set; }
    }
}