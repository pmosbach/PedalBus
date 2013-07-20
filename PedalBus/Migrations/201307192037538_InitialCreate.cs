namespace PedalBus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        SystemId = c.Int(nullable: false),
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
                        ExpirationDate = c.DateTime(nullable: false),
                        Comments = c.String(),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.AccountGroups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                        LastAction = c.String(),
                        LastRemoteUser = c.String(),
                        LastRemoteAddr = c.String(),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.AccountGroups", new[] { "AccountID" });
            DropIndex("dbo.Accounts", new[] { "PersonId" });
            DropForeignKey("dbo.AccountGroups", "AccountID", "dbo.Accounts");
            DropForeignKey("dbo.Accounts", "PersonId", "dbo.People");
            DropTable("dbo.AccountGroups");
            DropTable("dbo.Accounts");
            DropTable("dbo.People");
        }
    }
}
