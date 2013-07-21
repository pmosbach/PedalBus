using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Group
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int GID { get; set; }
        public bool Advertise { get; set; }
        public bool Pseudo { get; set; }
        public bool Privileged { get; set; }
        public InformationSensitivity Sensitivity { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
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