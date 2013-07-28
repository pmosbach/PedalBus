using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class PersonRole
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
        public bool Prime { get; set; }
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