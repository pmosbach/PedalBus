namespace PedalBus.Migrations
{
    using PedalBus.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<PedalBus.Models.PedalBusDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PedalBus.Models.PedalBusDb context)
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            }

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
                new Person
                {
                    GivenName = "John",
                    MiddleName = "C",
                    Surname = "Doe",
                    UUPIC = "111111111",
                    EmailAddress = "john.c.doe@pedal.bus",
                    Employer = "The Man",
                    OrgCode = "ZZTop",
                    MailStop = "LaGrange",
                    Bldg = "1",
                    Room = "101",
                    Phone = "281-555-1234",
                    DomainID = "FAT-MAN\\Peter",
                    AUID = "Peter",
                    USCitizen = true,
                    Citizenship = "US",
                    BirthCountry = "US",
                    LegalPermanentResident = false,
                    ForeignEmployer = false,
                    DisplayName = "Doe, John C",
                    ACPRequired = false,
                    ACPTTCPExpirationDate = DateTime.Parse("2014-06-01 00:00:00"),
                    ContactInfoExpirationDate = DateTime.Parse("2013-08-01 00:00:00"),
                    ITSecurityTrainingClass = "ITS-013-001",
                    ITSecurityTrainingDate = DateTime.Parse("2013-05-28 00:00:00"),
                    ITSecurityTrainingExpirationDate = DateTime.Parse("2014-05-28 00:00:00"),
                    ManagerExpirationDate = DateTime.Parse("2013-06-17 00:00:00"),
                    SurveyExpirationDate = DateTime.Parse("2013-09-09 00:00:00"),
                    MultiCitizen = false,
                    ManagerRoleId = 1,
                    LastModified = DateTime.Now,
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ApplicationId = 1,
                            Login = "jcdoe",
                            ExpirationDate = DateTime.Parse("2013-08-15 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 1,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 2,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        }
                    },
                    Roles = new List<PersonRole>
                    {
                        new PersonRole
                        {
                            RoleId = 1,
                            Prime = true,
                            LastAction = "Role Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now
                        }
                    }
                },
                new Person
                {
                    GivenName = "Jane",
                    MiddleName = "Q",
                    Surname = "Doe",
                    UUPIC = "222222222",
                    EmailAddress = "jane.q.doe@pedal.bus",
                    Employer = "The Man",
                    OrgCode = "ZZTop",
                    MailStop = "LaGrange",
                    Bldg = "1",
                    Room = "102",
                    Phone = "281-555-1111",
                    DomainID = "MOSBACHERHOME\\pmosbach",
                    AUID = "Lucy",
                    USCitizen = true,
                    Citizenship = "US",
                    BirthCountry = "US",
                    LegalPermanentResident = false,
                    ForeignEmployer = false,
                    DisplayName = "Doe, Jane Q",
                    ACPRequired = false,
                    ACPTTCPExpirationDate = DateTime.Parse("2013-08-22 00:00:00"),
                    ContactInfoExpirationDate = DateTime.Parse("2014-04-01 00:00:00"),
                    ITSecurityTrainingClass = "ITS-013-001",
                    ITSecurityTrainingDate = DateTime.Parse("2012-08-28 00:00:00"),
                    ITSecurityTrainingExpirationDate = DateTime.Parse("2012-08-28 00:00:00"),
                    ManagerExpirationDate = DateTime.Parse("2013-02-17 00:00:00"),
                    SurveyExpirationDate = DateTime.Parse("2013-12-09 00:00:00"),
                    MultiCitizen = false,
                    ManagerRoleId = 2,
                    LastModified = DateTime.Now,
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ApplicationId = 1,
                            Login = "jqdoe",
                            ExpirationDate = DateTime.Parse("2013-09-28 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 1,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 2,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        },
                        new Account
                        {
                            ApplicationId = 2,
                            Login = "jqdoe",
                            ExpirationDate = DateTime.Parse("2013-10-03 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 3,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 4,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        }
                    }
                },
                new Person
                {
                    GivenName = "Sherlock",
                    MiddleName = "Baca",
                    Surname = "Tremper",
                    UUPIC = "333333333",
                    EmailAddress = "sherlock.b.tremper@pedal.bus",
                    Employer = "The Man",
                    OrgCode = "ZZTop",
                    MailStop = "LaGrange",
                    Bldg = "1",
                    Room = "Corner Suite",
                    Phone = "281-555-4321",
                    DomainID = "MOSBACHERHOME\\stremper",
                    AUID = "Sherlock",
                    USCitizen = true,
                    Citizenship = "US",
                    BirthCountry = "US",
                    LegalPermanentResident = false,
                    ForeignEmployer = false,
                    DisplayName = "Tremper, Sherlock B",
                    ACPRequired = false,
                    ACPTTCPExpirationDate = DateTime.Parse("2013-12-13 00:00:00"),
                    ContactInfoExpirationDate = DateTime.Parse("2014-01-04 00:00:00"),
                    ITSecurityTrainingClass = "ITS-013-001",
                    ITSecurityTrainingDate = DateTime.Parse("2013-04-18 00:00:00"),
                    ITSecurityTrainingExpirationDate = DateTime.Parse("2014-04-18 00:00:00"),
                    ManagerExpirationDate = DateTime.Parse("2014-01-17 00:00:00"),
                    SurveyExpirationDate = DateTime.Parse("2013-12-09 00:00:00"),
                    MultiCitizen = false,
                    ManagerRoleId = 1,
                    LastModified = DateTime.Now,
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ApplicationId = 1,
                            Login = "stremper",
                            ExpirationDate = DateTime.Parse("2013-10-21 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 1,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 2,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        },
                        new Account
                        {
                            ApplicationId = 2,
                            Login = "stremper",
                            ExpirationDate = DateTime.Parse("2013-10-03 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 3,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 4,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        }
                    },
                    Roles = new List<PersonRole>
                    {
                        new PersonRole
                        {
                            RoleId = 2,
                            Prime = true,
                            LastAction = "Role Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now
                        }
                    }
                },
                new Person
                {
                    GivenName = "Rolph",
                    MiddleName = "Sterker",
                    Surname = "MacCabe",
                    UUPIC = "444444444",
                    EmailAddress = "rolph.s.maccabe@pedal.bus",
                    Employer = "The Man",
                    OrgCode = "ZZTop",
                    MailStop = "LaGrange",
                    Bldg = "1",
                    Room = "The Big Office",
                    Phone = "281-555-7777",
                    DomainID = "MOSBACHERHOME\\rmaccabe",
                    AUID = "Rolph",
                    USCitizen = true,
                    Citizenship = "US",
                    BirthCountry = "US",
                    LegalPermanentResident = false,
                    ForeignEmployer = false,
                    DisplayName = "MacCabe, Rolph S",
                    ACPRequired = false,
                    ACPTTCPExpirationDate = DateTime.Parse("2013-08-22 00:00:00"),
                    ContactInfoExpirationDate = DateTime.Parse("2014-04-01 00:00:00"),
                    ITSecurityTrainingClass = "ITS-013-001",
                    ITSecurityTrainingDate = DateTime.Parse("2012-08-28 00:00:00"),
                    ITSecurityTrainingExpirationDate = DateTime.Parse("2012-08-28 00:00:00"),
                    ManagerExpirationDate = DateTime.Parse("2013-02-17 00:00:00"),
                    SurveyExpirationDate = DateTime.Parse("2013-12-09 00:00:00"),
                    MultiCitizen = false,
                    ManagerRoleId = 1,
                    LastModified = DateTime.Now,
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ApplicationId = 1,
                            Login = "rmaccabe",
                            ExpirationDate = DateTime.Parse("2013-09-28 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 1,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 2,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        },
                        new Account
                        {
                            ApplicationId = 2,
                            Login = "rmaccabe",
                            ExpirationDate = DateTime.Parse("2013-10-03 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 3,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 4,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        }
                    }
                },
                new Person
                {
                    GivenName = "Lula",
                    MiddleName = "Cheely",
                    Surname = "Banana",
                    UUPIC = "666666666",
                    EmailAddress = "lula.c.banana@pedal.bus",
                    Employer = "The Man",
                    OrgCode = "ZZTop",
                    MailStop = "LaGrange",
                    Bldg = "1",
                    Room = "103",
                    Phone = "281-555-8888",
                    DomainID = "MOSBACHERHOME\\lbanana",
                    AUID = "Lula",
                    USCitizen = true,
                    Citizenship = "US",
                    BirthCountry = "US",
                    LegalPermanentResident = false,
                    ForeignEmployer = false,
                    DisplayName = "Banana, Lula C",
                    ACPRequired = false,
                    ACPTTCPExpirationDate = DateTime.Parse("2012-08-22 00:00:00"),
                    ContactInfoExpirationDate = DateTime.Parse("2012-04-01 00:00:00"),
                    ITSecurityTrainingClass = "ITS-013-001",
                    ITSecurityTrainingDate = DateTime.Parse("2013-04-28 00:00:00"),
                    ITSecurityTrainingExpirationDate = DateTime.Parse("2014-04-28 00:00:00"),
                    ManagerExpirationDate = DateTime.Parse("2013-03-20 00:00:00"),
                    SurveyExpirationDate = DateTime.Parse("2013-12-09 00:00:00"),
                    MultiCitizen = false,
                    ManagerRoleId = 2,
                    LastModified = DateTime.Now,
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ApplicationId = 1,
                            Login = "lbanana",
                            ExpirationDate = DateTime.Parse("2013-09-28 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 1,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 2,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        },
                        new Account
                        {
                            ApplicationId = 2,
                            Login = "lbanana",
                            ExpirationDate = DateTime.Parse("2013-10-03 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 3,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 4,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        }
                    }
                },
                new Person
                {
                    GivenName = "Bean",
                    MiddleName = "Yule",
                    Surname = "Callahan",
                    UUPIC = "777777777",
                    EmailAddress = "bean.y.callahan@pedal.bus",
                    Employer = "The Man",
                    OrgCode = "ZZTop",
                    MailStop = "LaGrange",
                    Bldg = "1",
                    Room = "104",
                    Phone = "281-555-0000",
                    DomainID = "MOSBACHERHOME\\bycallah",
                    AUID = "Bean",
                    USCitizen = true,
                    Citizenship = "US",
                    BirthCountry = "US",
                    LegalPermanentResident = false,
                    ForeignEmployer = false,
                    DisplayName = "Callahan, Bean Y",
                    ACPRequired = false,
                    ACPTTCPExpirationDate = DateTime.Parse("2013-03-23 00:00:00"),
                    ContactInfoExpirationDate = DateTime.Parse("2014-02-05 00:00:00"),
                    ITSecurityTrainingClass = "ITS-013-001",
                    ITSecurityTrainingDate = DateTime.Parse("2013-06-20 00:00:00"),
                    ITSecurityTrainingExpirationDate = DateTime.Parse("2014-06-20 00:00:00"),
                    ManagerExpirationDate = DateTime.Parse("2013-02-17 00:00:00"),
                    SurveyExpirationDate = DateTime.Parse("2013-12-09 00:00:00"),
                    MultiCitizen = false,
                    ManagerRoleId = 2,
                    LastModified = DateTime.Now,
                    Accounts = new List<Account>
                    {
                        new Account
                        {
                            ApplicationId = 1,
                            Login = "bycallah",
                            ExpirationDate = DateTime.Parse("2013-09-28 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 1,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 2,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        },
                        new Account
                        {
                            ApplicationId = 2,
                            Login = "bycallah",
                            ExpirationDate = DateTime.Parse("2013-10-03 00:00:00"),
                            GID = -1,
                            UID = -1,
                            Active = true,
                            Privilege = AccountPrivilege.Regular,
                            LastAction = "Account Created",
                            LastRemoteUser = "SEED",
                            LastRemoteAddr = "127.0.0.1",
                            LastModified = DateTime.Now,
                            Groups = new List<AccountGroup>
                            {
                                new AccountGroup {
                                    GroupId = 3,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                },
                                new AccountGroup {
                                    GroupId = 4,
                                    LastAction = "Account Created",
                                    LastRemoteUser = "SEED",
                                    LastRemoteAddr = "127.0.0.1",
                                    LastModified = DateTime.Now
                                }
                            }
                        }
                    }
                });

            context.Roles.AddOrUpdate(r => r.Name,
                new Role
                {
                    Name = "Manager - The Man",
                    Active = true,
                    Verified = true,
                    LastAction = "Account Created",
                    LastRemoteUser = "SEED",
                    LastRemoteAddr = "127.0.0.1",
                    LastModified = DateTime.Now
                },
                new Role
                {
                    Name = "Manager - ZZTop",
                    Active = true,
                    Verified = true,
                    LastAction = "Account Created",
                    LastRemoteUser = "SEED",
                    LastRemoteAddr = "127.0.0.1",
                    LastModified = DateTime.Now
                });
        }
    }
}
