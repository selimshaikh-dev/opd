namespace CMIS.Core.Constants
{
    public static class BindingConstants
    {
        public const string UserCreate = "UserID,PIN,FirstName,MiddleName,LastName,DOB,Sex,Nationality,EmploymentNumber,NoEmploymentNumber,CellPhone,LandPhone,Email,ContactAddress,Username,Password,ConfirmPassword,DesignationID,FacilityID";
        public const string ChangePassword = "CurrentPassword, NewPassword, ConfirmNewPassword";
        public const string EditUserProfile = "PIN,FirstName,MiddleName,LastName,DOB,Sex,Nationality,EmploymentNumber,NoEmploymentNumber,CellPhone,LandPhone,Email,ContactAddress,DesignationID";
        public const string UserLogin = "Username, Password, LoginFacilityID";

        public const string ClientCreat = "PIN,FirstName,MiddleName,LastName,DOB,Sex,MaritalStatus,Nationality,IsClientDisabled,ResidentialAddress,ChiefdomID,PostalAddress,CellphoneCountryCode,Cellphone,LandPhoneCountryCode,LandPhone,Email,PatientID,RootPatientID,FacilityCode";
        public const string ClientEdit = "ClientID,PIN,FirstName,MiddleName,LastName,DOB,Sex,MaritalStatus,Nationality,IsClientDisabled,DeceasedDate,ResidentialAddress,ChiefdomID,PostalAddress,CellphoneCountryCode,Cellphone,LandPhoneCountryCode,LandPhone,Email,DateCreated,CreatedBy,RowStatus,fallbackURL,MothersID,PatientID,RootPatientID,FacilityCode";

        public const string AppointementCreate = "AppointmentID, AppointmentDate, Note, IsClientIn, FacilityCode, DateCreated, CreatedBy, DateModified, ModifieBy, RowStatus, SyncStatus, ClientID, EntryPointID";
        public const string AppointmentEdit = "AppointmentID, AppointmentDate, Note, IsClientIn, FacilityCode, DateModified, ModifieBy, RowStatus, SyncStatus, ClientID, EntryPointID";

        public const string Prescription = "DrugDescriptionID, DrugGroupID, DrugDirectionID, DrugFormID, DrugIntervalID, Duration, Quantity, DrugNotes, Notes, Prescriber, PrescriptionDate";

        //OUT PATIENT:
        public const string TBScreening = "TBScreeningID,Fever,NightSweats,WeightLoss,ChestPain,TBContact,ScreeningResult,SputumCollected,Referred,ClientID,CoughDurationID";
        public const string MC = "MCID,MCDate,Marcaine,DPNB,DPNBRingblock,LignocaineOne,LignocaineTwo,DiathermyUsed,Frequency,Cut,Coagulation,MCProcedureID,MCMethodID,ClientID";
        public const string MCPostOpReview = "MCPostOpReviewID,ReviewDate,SeverityGrade,MCAdverseEventID,ClientID";

        public const string CervicalCancer = "PAPSmearResult, CervicalCancerTestResultID, VIAResult, BreastPalpationExamDone, BiopsyDone, CervicalCancerBiopsyResultID, CervicalAbnormalities, Remarks, CervicalTreatmentID, ClientID";
        public const string PNCChild = "GivenINVP, EIMCDiscussed, PNCChildConditionOfUmbilicalCordID, FeedingOptionID, ClientID";
    }
}
