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
        [UIHint("Enum")]
        public LDAPDomain Domain { get; set; }
        [UIHint("Enum")]
        public SystemType Type { get; set; }
        [UIHint("Enum")]
        [Display(Name = "FIPS 199 Categorization")]
        public FIPSCategorization Categorization { get; set; }
        [UIHint("Enum")]
        public ManagingContract Class { get; set; }
        [Display(Name = "Allow Adds?")]
        public bool AllowAdds { get; set; }
        [Display(Name = "Advertise?")]
        public bool Advertise { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Filesystem Path to Information File")]
        public string PathToFile { get; set; }
        [Display(Name = "URL Path to Information File")]
        public string URLPathToFile { get; set; }
        [Display(Name = "Last Action")]
        public string LastAction { get; set; }
        [Display(Name = "Last Remote User")]
        public string LastRemoteUser { get; set; }
        [Display(Name = "Last Remote Address")]
        public string LastRemoteAddr { get; set; }
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }

    public enum LDAPDomain
    {
        OPS,
        SNS,
        NDC,
        [Display(Name="MCC21 Critical")]
        MC,
        [Display(Name="MSSC")]
        FD,
        LAUNCHPAD,
        [Display(Name="Other")]
        OTHER
    }

    public enum SystemType
    {
        Pseudo,
        Windows,
        [Display(Name="Linux-Unix")]
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