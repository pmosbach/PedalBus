namespace PedalBus.Migrations
{
    using PedalBus.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PedalBus.Models.PedalBusDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PedalBus.Models.PedalBusDb context)
        {
            context.Applications.AddOrUpdate(r => r.ShortName,
                new Application
                { 
                    ShortName = "VADER",
                    LongName = "Video Audio Digital Enterprise Resource",
                    Advertise = true,
                    AllowAdds = true,
                    Class = ManagingContract.Other,
                    Categorization = FIPSCategorization.Low,
                    Domain = LDAPDomain.OTHER,
                    Type = SystemType.Pseudo,
                    Groups = new List<Group> {
                        new Group { ShortName = "2090 Admin", LongName = "CR2090 Administrator", Advertise = true, Privileged = false, Pseudo = true, Sensitivity = InformationSensitivity.Public, LastModified = DateTime.Now },
                        new Group { ShortName = "OS1 Admin", LongName = "Ops Suite 1 Administrator", Advertise = true, Privileged = false, Pseudo = true, Sensitivity = InformationSensitivity.Unknown, LastModified = DateTime.Now }
                    },
                    LastModified = DateTime.Now
                },
                new Application
                {
                    ShortName = "Plex",
                    LongName = "Peter's Plex Server",
                    Advertise = true,
                    AllowAdds = true,
                    Class = ManagingContract.Other,
                    Categorization = FIPSCategorization.Moderate,
                    Domain = LDAPDomain.OTHER,
                    Type = SystemType.Pseudo,
                    Groups = new List<Group> {
                        new Group { ShortName = "Friends", LongName = "Friends", Advertise = true, Privileged = false, Pseudo = true, Sensitivity = InformationSensitivity.Public, LastModified = DateTime.Now },
                        new Group { ShortName = "Inner Circle", LongName = "Inner Circle", Advertise = true, Privileged = false, Pseudo = true, Sensitivity = InformationSensitivity.Unknown, LastModified = DateTime.Now }
                    },
                    LastModified = DateTime.Now
                }
                );
            context.People.AddOrUpdate(r => r.UUPIC,
                new Person { GivenName = "John", MiddleName = "C", Surname = "Doe", UUPIC= "111111111", EmailAddress = "john.c.doe@pedal.bus", Employer = "The Man", OrgCode = "ZZTop", MailStop = "LaGrange", Bldg = "1", Room = "101", Phone = "281-555-1234", DomainID = "FAT-MAN\\Peter", AUID = "Peter", USCitizen = true, Citizenship = "US", BirthCountry = "US", LegalPermanentResident = false, ForeignEmployer = false, DisplayName = "Doe, John C", ACPRequired = false, ACPTTCPExpirationDate = DateTime.Parse("2014-06-01 00:00:00"), ContactInfoExpirationDate = DateTime.Parse("2013-08-01 00:00:00"), ITSecurityTrainingClass = "ITS-013-001", ITSecurityTrainingDate = DateTime.Parse("2013-05-28 00:00:00"), ITSecurityTrainingExpirationDate = DateTime.Parse("2014-05-28 00:00:00"), ManagerExpirationDate = DateTime.Parse("2013-06-17 00:00:00"), SurveyExpirationDate = DateTime.Parse("2013-09-09 00:00:00"), MultiCitizen = false, LastModified = DateTime.Now},
                new Person { GivenName = "Jane", MiddleName = "Q", Surname = "Doe", UUPIC = "222222222", EmailAddress = "jane.q.doe@pedal.bus", Employer = "The Man", OrgCode = "ZZTop", MailStop = "LaGrange", Bldg = "1", Room = "102", Phone = "281-555-1111", DomainID = "FAT-MAN\\Lucy", AUID = "Lucy", USCitizen = true, Citizenship = "US", BirthCountry = "US", LegalPermanentResident = false, ForeignEmployer = false, DisplayName = "Doe, Jane Q", ACPRequired = false, ACPTTCPExpirationDate = DateTime.Parse("2013-08-22 00:00:00"), ContactInfoExpirationDate = DateTime.Parse("2014-04-01 00:00:00"), ITSecurityTrainingClass = "ITS-013-001", ITSecurityTrainingDate = DateTime.Parse("2012-08-28 00:00:00"), ITSecurityTrainingExpirationDate = DateTime.Parse("2012-08-28 00:00:00"), ManagerExpirationDate = DateTime.Parse("2013-02-17 00:00:00"), SurveyExpirationDate = DateTime.Parse("2013-12-09 00:00:00"), MultiCitizen = false, LastModified = DateTime.Now }
                );
        }
    }
}
