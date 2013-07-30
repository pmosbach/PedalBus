using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public bool AgreedToUSOR { get; set; }
        [Display(Name = "Privileged Request?")]
        public bool RequestPrivileged { get; set; }
        [Display(Name = "Changed Employer?")]
        public bool ChangedEmployer { get; set; }
        [Display(Name = "Changed Name?")]
        public bool ChangedName { get; set; }
        public int MatchingPersonId { get; set; }
        public string LocalityFilter { get; set; }
        public DateTime LastModified { get; set; }
        public virtual ICollection<RequestedApplication> RequestedApplications { get; set; }
    }
}