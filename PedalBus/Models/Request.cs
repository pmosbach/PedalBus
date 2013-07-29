using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedalBus.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public int AccountId { get; set; }
        public string RequestClass { get; set; }
        public bool RequestLocked { get; set; }
        public int RequestorId { get; set; }
        public int ManagerId { get; set; }
        public string RequestorSurname { get; set; }
	    public string RequestorGivenName { get; set; }
        public string RequestorMiddleName { get; set; }
        public string RequestorEmailAddress { get; set; }
        public string RequestorEmployer { get; set; }
        public string RequestorOrgCode { get; set; }
        public string RequestorMailStop { get; set; }
        public string RequestorBldg { get; set; }
        public string RequestorRoom { get; set; }
        public string RequestorPhone { get; set; }
	    public bool RequestorUSCitizen { get; set; }
        public bool RequestorMultiCitizen { get; set; }
        public bool RequestorLegalPermanentResident { get; set; }
        public bool RequestorForeignEmployer { get; set; }
        public string RequestorCitizenship { get; set; }
        public DateTime RequestorITSTrainingDate { get; set; }
        public string RequestorITSTrainingSource { get; set; }
        public string RequestorUUPIC { get; set; }
        public string RequestorAUID { get; set; }
        public string RequestorACPText { get; set; }
        public string RequestorACPLink { get; set; }
        public string ManagerSurname { get; set; }
        public string ManagerGivenName { get; set; }
        public string ManagerMiddleName { get; set; }
        public string ManagerEmailAddress { get; set; }
        public string ManagerEmployer { get; set; }
        public string ManagerOrgCode { get; set; }
        public string ManagerMailStop { get; set; }
        public string ManagerBldg { get; set; }
        public string ManagerRoom { get; set; }
        public string ManagerPhone { get; set; }
        public string RequestTitle { get; set; }
        public string RequestNAMSNum { get; set; }
        public bool RequestPrivileged { get; set; }
        public string RequestDetails { get; set; }
        public string RequestNotes { get; set; }
        public string RequestJustification { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime WithdrawDate { get; set; }
        public string Disposition { get; set; }
        public DateTime DispositionDate { get; set; }
        public string Comments { get; set; }
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