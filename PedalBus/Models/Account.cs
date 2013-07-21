using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int SystemId { get; set; }
        public bool Active { get; set; }
        public string Login { get; set; }
        public int UID { get; set; }
        public int GID { get; set; }
        public string GECOS { get; set; }
        public string HomeDirectory { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string HomePath { get; set; }
        public string ProfilePath { get; set; }
        public string LogonScriptPath { get; set; }
        public AccountPrivilege Privilege { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Comments { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
        public DateTime LastModified { get; set; }
        public ICollection<AccountGroup> Groups { get; set; }
    }

    public enum AccountPrivilege { Regular, GA, Privileged }
}