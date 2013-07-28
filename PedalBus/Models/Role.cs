using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool Active { get; set; }
        public bool Verified { get; set; }
        [Display(Name = "Last Action")]
        public string LastAction { get; set; }
        [Display(Name = "Last Remote User")]
        public string LastRemoteUser { get; set; }
        [Display(Name = "Last Remote Address")]
        public string LastRemoteAddr { get; set; }
        [Display(Name = "Last Modified")]
        public DateTime LastModified { get; set; }
    }
}