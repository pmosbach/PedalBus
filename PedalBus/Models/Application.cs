using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Application
    {
        public int Id { get; set; }
        [Display(Name = "Short Name")]
        [Required]
        public string ShortName { get; set; }
        [Display(Name = "Long Name")]
        [Required]
        public string LongName { get; set; }
        public LDAPDomain Domain { get; set; }
        public SystemType Type { get; set; }
        [Display(Name = "FIPS 199 Categorization")]
        public FIPSCategorization Categorization { get; set; }
        public ManagingContract Class { get; set; }
        [Display(Name = "Allow Adds?")]
        public bool AllowAdds { get; set; }
        [Display(Name = "Advertise?")]
        public bool Advertise { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PathToFile { get; set; }
        public string URLPathToFile { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }
        public ICollection<Group> Groups { get; set; }
    }

    public enum LDAPDomain
    {
        OPS,
        SNS,
        NDC,
        MC,
        FD,
        LAUNCHPAD,
        OTHER
    }

    public enum SystemType
    {
        Pseudo,
        Windows,
        LinuxUnix
    }

    public enum FIPSCategorization
    {
        High,
        Moderate,
        Low
    }

    public enum ManagingContract
    {
        FDOC,
        Other
    }
}