using CMIS.Core.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using static CMIS.Core.Constants.Enumerators;

namespace CMIS.Core.Models.Entities
{
    [Table("HTS")]
    public class HTS
    {
        [Key]
        public Guid HTSID { get; set; }

        [IfYesNoNotSelected]
        [Display(Name = "Client tested for HIV?")]
        public YesNo HasClientTestedForHIV { get; set; }

        [HTSIfHIVTestDateNotSelected]
        [IfFutureDate]
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Recent HIV test date")]
        public DateTime? WhatWasTheTestDate { get; set; }

        [HTSIfTestResultNotSelected]
        [Display(Name = "Recent HIV test result")]
        public HIVStatus WhatWasTheTestResult { get; set; }

        [Display(Name = "Partner's recent HIV status?")]
        public HIVStatus PartnersHIVStatus { get; set; }

        [HTSIfClientOnArtNotSelected]
        [Display(Name = "Client already on ART?")]
        public YesNo IsClientOnART { get; set; }

        [HTSIfConsentForTestingNotSelected]
        [Display(Name = "Consent for testing?")]
        public YesNo ConsentForTesting { get; set; }

        [HTSIfTestTypeNotSelected]
        [Display(Name = "Test type")]
        public TestType TestType { get; set; }

        [HTSIfTestModalityNotSelected]
        [Display(Name = "Test modality")]
        public TestModality TestModality { get; set; }

        [StringLength(20)]
        [Display(Name = "Inviter's index code")]
        public string IndexCodeInviter { get; set; }

        [HTSIfIndexCodeIsBlank]
        [StringLength(20)]
        [Display(Name = "Index code")]
        public string IndexCodeInvitee { get; set; }

        [Display(Name = "Number of invitations")]
        public int? NumberOfInvitees { get; set; }

        [Display(Name = "HIV rapid test - Determine")]
        public HIVTestResult Determined { get; set; }

        [HTSIfDetermineDateNotSelected]
        [IfFutureDate]
        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeterminedDate { get; set; }

        [HTSIfUniGoldNotSelected]
        [Display(Name = "HIV rapid test - Uni Gold")]
        public HIVTestResult UniGold { get; set; }

        [HTSIfUniGoldDateNotSelected]
        [HTSIfUniGoldDateNotMatchingDetermineDate]
        [IfFutureDate]
        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? UniGoldDate { get; set; }

        [HTSIfDNAPCRSampleCollectedNotSelected]
        [Display(Name = "DNA PCR sample collected?")]
        public YesNo DNAPCRSampleCollected { get; set; }

        [HTSIfDNAPCRCollectionDateNotSelected]
        [HTSIfDNAPCRSampleCollectionDateIsFutureDate]
        [HTSIfDNAPCRCollectionDateNotMatchingOtherTestsDate]
        [Display(Name = "DNA PCR collection date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? DNAPCRCollectionDate { get; set; }

        //[HTSIfDNAPCRNotSelected]
        [Display(Name = "DNA PCR")]
        public DNAPCRHIVStatus DNAPCR { get; set; }

        //[HTSIfDNAPCRDateNotSelected]
        //[IfFutureDate]
        [HTSIfDNAPCRDateIsOutOfRange]
        [Display(Name = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? DNAPCRDate { get; set; }

        [Display(Name = "Final HIV status")]
        public HIVStatus FinalHIVStatus { get; set; }

        [Display(Name = "Client received results?")]
        public YesNo? ResultReceived { get; set; }

        [IfOldDate]
        [Display(Name = "Retest date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Column(TypeName = "smalldatetime")]
        public DateTime? ReTestDate { get; set; }

        public Guid ClientID { get; set; }

        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        [Display(Name = "Entry point")]
        public int EntryPointID { get; set; }

        [ForeignKey("EntryPointID")]
        public virtual EntryPoint EntryPoint { get; set; }

        [HTSIfTestedAsNotSelected]
        [Display(Name = "Tested as")]
        public int? HTSTestOptionID { get; set; }

        [ForeignKey("HTSTestOptionID")]
        public virtual HTSTestOption HTSTestOption { get; set; }

        [StringLength(10)]
        public string FacilityCode { get; set; }

        public Guid? VisitID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }

        public Guid? CreatedBy { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateModified { get; set; }

        public Guid? ModifiedBy { get; set; }

        public RowStatus? RowStatus { get; set; }

        public RowSyncStatus? SyncStatus { get; set; }

        public virtual IQueryable<HTSInvitee> HTSInvitee { get; set; }
    }
}