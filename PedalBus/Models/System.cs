using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class System
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public LDAPDomain Domain { get; set; }
        public SystemType Type { get; set; }
        public FIPSClassification Classification { get; set; }
        public ManagingContract Class { get; set; }
        public bool AllowAdds { get; set; }
        public bool Advertise { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PathToFile { get; set; }
        public string URLPathToFile { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
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

    public enum FIPSClassification
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