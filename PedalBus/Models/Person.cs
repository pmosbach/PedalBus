using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string AUID { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string EmailAddress { get; set; }
        public string MailStop { get; set; }
        public string Bldg { get; set; }
        public string Room { get; set; }
        public string Phone { get; set; }
        public string X500ID { get; set; }
        public string UUPIC { get; set; }
        public string Employer { get; set; }
        public string OrgCode { get; set; }
        public string DisplayName { get; set; }
        public string Mobile { get; set; }
        public string DomainID { get; set; }
        public string Center { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public bool USCitizen { get; set; }
        public bool MultiCitizen { get; set; }
        public string Citizenship { get; set; }
        public string BirthCountry { get; set; }
        public bool LegalPermanentResident { get; set; }
        public bool ForeignEmployer { get; set; }
        public string Question { get; set; }
        public string QuestionAnswer { get; set; }
        public DateTime ITSecurityTrainingDate { get; set; }
        public string ITSecurityTrainingClass { get; set; }
        public bool ACPRequired { get; set; }
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
        public ICollection<Account> Accounts { get; set; }
    }
}