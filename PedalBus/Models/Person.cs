using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Person
    {
        [Display(Name = "PedalBus ID")]
        public int Id { get; set; }
        public string AUID { get; set; }
        [Display(Name = "Last Name (Surname)", ShortName = "Last Name")]
        public string Surname { get; set; }
        [Display(Name = "First Name (Given Name)", ShortName = "First Name")]
        public string GivenName { get; set; }
        [Display(Name = "Middle Name (or Initial)", ShortName = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Mail Stop")]
        public string MailStop { get; set; }
        [Display(Name = "Building", ShortName = "Bldg")]
        public string Bldg { get; set; }
        public string Room { get; set; }
        public string Phone { get; set; }
        [Display(Name = "Legacy Unique ID (X.500 ID)", ShortName = "Legacy ID")]
        public string X500ID { get; set; }
        public string UUPIC { get; set; }
        public string Employer { get; set; }
        [Display(Name = "Org Code")]
        public string OrgCode { get; set; }
        [Display(Name = "Display Name", ShortName = "Name")]
        public string DisplayName { get; set; }
        public string Mobile { get; set; }
        [Display(Name = "Domain Login", ShortName = "Login")]
        public string DomainID { get; set; }
        public string Center { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Display(Name = "US Citizen?")]
        public bool USCitizen { get; set; }
        [Display(Name = "Multiple Citizenships?", ShortName = "Multi-Citizen")]
        public bool MultiCitizen { get; set; }
        public string Citizenship { get; set; }
        [Display(Name = "Birth Country")]
        public string BirthCountry { get; set; }
        [Display(Name = "Legal Permanent Resident?", ShortName = "LPR?")]
        public bool LegalPermanentResident { get; set; }
        [Display(Name = "Foreign Employer?")]
        public bool ForeignEmployer { get; set; }
        [Display(Name = "Secret Question")]
        public string Question { get; set; }
        [Display(Name = "Secret Answer")]
        public string QuestionAnswer { get; set; }
        [Display(Name = "IT Security Training Date", ShortName = "ITS Training Date")]
        public DateTime ITSecurityTrainingDate { get; set; }
        [Display(Name = "IT Security Training Class", ShortName = "ITS Training Class")]
        public string ITSecurityTrainingClass { get; set; }
        [Display(Name = "ACP/TTCP Required?")]
        public bool ACPRequired { get; set; }
        [Display(Name = "ACP/TTCP Identifier")]
        public string ACPTTCPIdentifier { get; set; }
        public DateTime ContactInfoExpirationDate { get; set; }
        public DateTime SurveyExpirationDate { get; set; }
        public DateTime ManagerExpirationDate { get; set; }
        public DateTime ITSecurityTrainingExpirationDate { get; set; }
        public DateTime ACPTTCPExpirationDate { get; set; }
        public string LastAction { get; set; }
        public string LastRemoteUser { get; set; }
        public string LastRemoteAddr { get; set; }
        public DateTime LastModified { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}