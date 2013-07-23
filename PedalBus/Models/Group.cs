using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        [Display(Name = "Short Name")]
        public string ShortName { get; set; }
        [Display(Name = "Long Name")]
        public string LongName { get; set; }
        public int GID { get; set; }
        public bool Advertise { get; set; }
        public bool Pseudo { get; set; }
        public bool Privileged { get; set; }
        public InformationSensitivity Sensitivity { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }
    }

    public enum InformationSensitivity
    {
        Unknown,
        Public,
        EAR99,
        ITAR,
        SBU,
        Proprietary
    }
}