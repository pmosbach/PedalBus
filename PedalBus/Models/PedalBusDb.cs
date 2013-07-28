using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class PedalBusDb : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PersonRole> PeopleRoles { get; set; }
    }
}