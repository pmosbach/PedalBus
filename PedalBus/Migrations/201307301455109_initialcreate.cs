namespace PedalBus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AUID = c.String(),
                        Surname = c.String(),
                        GivenName = c.String(),
                        MiddleName = c.String(),
                        EmailAddress = c.String(),
                        MailStop = c.String(),
                        Bldg = c.String(),
                        Room = c.String(),
                        Phone = c.String(),
                        X500ID = c.String(),
                        UUPIC = c.String(),
                        Employer = c.String(),
                        OrgCode = c.String(),
                        DisplayName = c.String(),
                        Mobile = c.String(),
                        DomainID = c.String(),
                        Center = c.String(),
                        Title = c.String(),
                        Address = c.String(),
                        State = c.String(),
                        PostalCode = c.String(),
                        USCitizen = c.Boolean(nullable: false),
                        MultiCitizen = c.Boolean(nullable: false),
                        Citizenship = c.String(),
                        BirthCountry = c.String(),
                        LegalPermanentResident = c.Boolean(nullable: false),
                        ForeignEmployer = c.Boolean(nullable: false),
                        Question = c.String(),
                        QuestionAnswer = c.String(),
                        ITSecurityTrainingDate = c.DateTime(nullable: false),
                        ITSecurityTrainingClass = c.String(),
                        ACPRequired = c.Boolean(nullable: false),
                        ACPTTCPIdentifier = c.String(),
                        ManagerRoleId = c.Int(nullable: false),
                        ContactInfoExpirationDate = c.DateTime(nullable: false),
                        SurveyExpirationDate = c.DateTime(nullable: false),
                        ManagerExpirationDate = c.DateTime(nullable: false),
                        ITSecurityTrainingExpirationDate = c.DateTime(nullable: false),
                        ACPTTCPExpirationDate = c.DateTime(nullable: false),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        ApplicationId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Login = c.String(),
                        UID = c.Int(nullable: false),
                        GID = c.Int(nullable: false),
                        GECOS = c.String(),
                        HomeDirectory = c.String(),
                        FullName = c.String(),
                        Description = c.String(),
                        HomePath = c.String(),
                        ProfilePath = c.String(),
                        LogonScriptPath = c.String(),
                        Privilege = c.Int(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        Comments = c.String(),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.AccountGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.PersonRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        Prime = c.Boolean(nullable: false),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShortName = c.String(nullable: false),
                        LongName = c.String(nullable: false),
                        Domain = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Categorization = c.Int(nullable: false),
                        Class = c.Int(nullable: false),
                        AllowAdds = c.Boolean(nullable: false),
                        Advertise = c.Boolean(nullable: false),
                        Description = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        PathToFile = c.String(),
                        URLPathToFile = c.String(),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                        AccountId = c.Int(),
                        Outcome = c.String(),
                        Justification = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        RequestFlow_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RequestFlows", t => t.RequestFlow_Id)
                .Index(t => t.RequestFlow_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationId = c.Int(nullable: false),
                        ShortName = c.String(),
                        LongName = c.String(),
                        GID = c.Int(nullable: false),
                        Advertise = c.Boolean(nullable: false),
                        Pseudo = c.Boolean(nullable: false),
                        Privileged = c.Boolean(nullable: false),
                        Sensitivity = c.Int(nullable: false),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                        AccountGroupId = c.Int(),
                        Outcome = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        RequestedApplication_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Applications", t => t.ApplicationId, cascadeDelete: true)
                .ForeignKey("dbo.Applications", t => t.RequestedApplication_Id)
                .Index(t => t.ApplicationId)
                .Index(t => t.RequestedApplication_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Comments = c.String(),
                        Active = c.Boolean(nullable: false),
                        Verified = c.Boolean(nullable: false),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RequestFlows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestorId = c.Int(nullable: false),
                        SubmitterId = c.Int(nullable: false),
                        RequestClass = c.String(),
                        FurthestStep = c.String(),
                        AgreedToUSOR = c.Boolean(nullable: false),
                        RequestPrivileged = c.Boolean(nullable: false),
                        ChangedEmployer = c.Boolean(nullable: false),
                        ChangedName = c.Boolean(nullable: false),
                        MatchingPersonId = c.Int(nullable: false),
                        LocalityFilter = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Groups", new[] { "RequestedApplication_Id" });
            DropIndex("dbo.Groups", new[] { "ApplicationId" });
            DropIndex("dbo.Applications", new[] { "RequestFlow_Id" });
            DropIndex("dbo.PersonRoles", new[] { "PersonId" });
            DropIndex("dbo.AccountGroups", new[] { "AccountId" });
            DropIndex("dbo.Accounts", new[] { "PersonId" });
            DropForeignKey("dbo.Groups", "RequestedApplication_Id", "dbo.Applications");
            DropForeignKey("dbo.Groups", "ApplicationId", "dbo.Applications");
            DropForeignKey("dbo.Applications", "RequestFlow_Id", "dbo.RequestFlows");
            DropForeignKey("dbo.PersonRoles", "PersonId", "dbo.People");
            DropForeignKey("dbo.AccountGroups", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "PersonId", "dbo.People");
            DropTable("dbo.RequestFlows");
            DropTable("dbo.Roles");
            DropTable("dbo.Groups");
            DropTable("dbo.Applications");
            DropTable("dbo.PersonRoles");
            DropTable("dbo.AccountGroups");
            DropTable("dbo.Accounts");
            DropTable("dbo.People");
        }
    }
}
