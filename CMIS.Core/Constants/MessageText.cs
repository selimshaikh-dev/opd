namespace CMIS.Core.Constants
{
    public static class MessageText
    {
        public const string DefaultErrorMessage = "Unable to perform this operation!";
        public const string RequiredField = "Required!";
        public const string AccessDenied = "Access denied! You don’t have access to this module.";
        public const string ReminderToBringPin = "Please remind client to bring PIN in next visit.";
        //COMMON:
        public const string RequiredFieldEmpty = "One or more required fields are blank! Review the form below to submit.";
        public const string InvalidRequest = "Invalid request! System did not find anything to process.";
        public const string NoMatchFound = "No match found!";
        public const string CitizenProfileNotFound = "No match found in citizen database! Proceed with Code 9 or Code 1.";
        public const string RequiredFacilityServicePoint = "Facility service point is required!";
        public const string RecordExists = "Record already exists.";
        public const string RecordSavedSuccessfully = "Record saved successfully.";
        public const string NothingToSave = "No information has been supplied! There is nothing to save.";
        public const string ClientDoesNotHaveHSTRecord = "Client does not have any latest HTS record, please capture HTS for this client.";
        public const string ClientHTSRecordOld = "Client HTS Record older than 2 months, please capture new HTS for this client.";
        public const string ExistingAppointment = "Client already has an appointment within the date range";
        public const string InvalidAppointment = "Appointment date cannot be historic";
        public const string ClientWithoutVerificationTest = "Client does not have an HTS verification Test, please capture a verification test for this client.";
        public const string ClientNotEligibleForTheService = "Client is not eligible for this service, HIV status is not positive.";
        public const string DateOutOfrange = "Date out of range, selection must be within 31 days.";
        public const string InvalidDateRange = "Invalid date range.";


        //USER PROFILE REGISTRATION:
        public const string UsernameTaken = "Username already taken! Please try another one.";
        public const string PINAlreadyExist = "User account already exists with this PIN.";
        public const string UserRegisteredSuccessfully = "User profile registered successfully.";
        public const string UserPasswordUpdatedSuccessfully = "User password updated successfully.";
        public const string UserRecordUpdatedSuccessfully = "User profile updated successfully.";
        public const string UserUnderAged = "Cannot register user! User is below 18 years old.";

        //USER LOGIN :
        public const string AccountInactive = "User account is inactive! Contact with administrator to activate the account.";
        public const string InvalideLogin = "Invalid username or password!";
        public const string IncorrectOldPassword = "Current password did not match!";
        public const string InvalidUserType = "Access denied!";
        public const string InvalidFacility = "Invalid facility!";
        //CLIENT PROFILE:
        public const string ClientRegisteredSuccessfully = "Client registered successfully.";
        public const string ClientUpdatedSucessfulle = "Client updated successfully.";
        public const string ClientAlreadyExist = "Client already registered with this PIN!";

        //RELATIVES:
        public const string RelativeRegisteredSuccessfully = "Relative registered successfully.";
        public const string RelativeUpdatedSuccessfully = "Relative’s profile updated successfully.";

        //MOTHER AND CHILD LINKAGE
        public const string MotherChildLInkedSuccessfully = "Mother and child linked successfully.";

        //APPOINTMENT:
        public const string AppointmentCreatedSuccessfully = "Appointment created successfully.";
        public const string AppointmentUpdatedSuccessfully = "Appointment updated successfully.";
        public const string AppointmentDateNotFutureDate = "Appointment date should not be historical date";

        //HISTORIC VISIT
        public const string HistoricVisitDateIsFutureDate = "Visit date cannot be a current/future date";

        //CUSTOM VALIDATION MESSAGES:       
        public const string SexRequired = "Sex was not selected!";
        public const string NationalityRequired = "Nationality was not selected!";
        public const string EmploymentNumberRequired = "Employment number is required!";
        public const string MaritalStatusRequired = "Marital status is required";
        public const string RelationshipRequired = "Relationship is required";
        public const string SomethingWentWrong = "Something went wrong! Please review the form below.";

        //MC
        public const string MCDateIsFutureDate = "MC date cannot be a future date";
        public const string MCSurgeryDateIsFutureDate = "Surgery date cannot be future date";

        //MC POST OP REVIEW
        public const string MCPostOpReviewDateIsFutureDate = "Review date cannot be a future date";
        public const string MCPostOpReviewDateLessThanMCDate = "Review date cannot be before VMMC date";
        public const string MCPostOpReviewAdverseEventIsSelected = "Severity grade is required";
        public const string MCPostOpReviewAdverseEventNotSelected = "Adverse event is required";

        //MATERNITY
        public const string MaternityAdmissionDateIsFutureDate = "Admission date cannot be a future date";
        public const string MaternityDischargeDateIsFutureDate = "Discharge date cannot be a future date";
        public const string MaternityDischargeDateIsBelowAdmissionDate = "Discharge date cannot be less than admission date";
        public const string MaternityDeliveryDateLessThanAdmissionDate = "Delivery cannot be less than admission date";
        public const string MaternityDeliveryDateGreaterThanDischargeDate = "Delivery cannot be greater than discharge date";

        //ART
        public const string RequiredARTStartDate = "ART start date is required";
        public const string RequiredWHOStageChangeReason = "WHO stage change reason is required";
        public const string RequiredARTRegimenChangeReason = "Reason for change is required";
        public const string RequiredARTCareModelChangeReason = "Reason for change is required";

        //TB SCREENING
        public const string InvalidCoughDuration = "Cough duration should be atleast 0 week";
        public const string RequiredSputumCollection = "Sputum collected is required";
        public const string RequiredReferred = "Referred is required";
        public const string RequiredTBContact = "TB contact is required";

        //TBDS
        public const string RequiredPatientCategory = "Patient category is required";
        public const string RequiredInterimOutcome = "Interim outcome is required";
        public const string RequiredRxOutcome = "RxOutcome is required";

        //TBDR
        public const string RequiredAdverseEventStatus = "Adverse event status is required";
        public const string EndDateLessThanOnsetDate = "End date cannot be less than onset date";
        public const string OnsetDateIsFutureDate = "Onset date cannot be future date";
        public const string EndDateIsFutureDate = "End date cannot be future date";

        //REFERRAL
        public const string ReferralDateIsFutureDate = "Referral date cannot be a future date";
        public const string ExpectedDateIsOldDate = "Expected date cannot be less than referral date";
        public const string ServicePointNotSelected = "Service point is required";

        //INPATIENT
        public const string AdmissionDateIsFutureDate = "Admission date cannot be a future date";
        public const string EstimatedDischargeDateIsLessThanAdmissionDate = "Estimated discharge date cannot be less than admission date";
        public const string DischargeDateIsLessThanAdmissionDate = "Discharge date cannot be less than admission date";
        public const string ProcedureDateIsRequired = "Procedure date is required";
        public const string ProcedureDateNotBetweenAdmissionAndEstimatedLOS = "Procedure date should be between admission date and estimated discharge date";
        public const string ProcedureDescriptionIsRequired = "Procedure description is required";
        public const string DischargeDateIsRequired = "Discharge date is required";
        public const string DischargeDateIsBeforeProcedureDate = "Discharge date cannot be before procedure date";
        public const string DischargeStatusIsRequired = "Discharge status is required";

        //VITAL
        public const string WeightRange = "Weight should be between 1kg and 200kg";
        public const string HeightRange = "Height should be between 1cm and 250cm";
        public const string HeightNull = "Required";
        public const string TemperatureRange = "Temperature should be between 30 and 45";
        public const string MUACRange = "MUAC should be between 1cm and 200cm";
        public const string RespiratoryRateRange = "Respiratory rate should be between 1bpm and 70bpm";
        public const string PulseRange = "Pulse should be between 1bpm and ";
        public const string OxygenSaturationRange = "Oxygen saturation range should be between";
        public const string BPSystolicNull = "Systolic value is required";
        public const string BPDiastolicNull = "Diastolic value is required";
        public const string DiastolicGreaterThanSystolic = "Diastolic cannot be greater than Systolic";
        public const string BPSystolicRange = "Systolic should be between 1mmHg and 200mmHg";
        public const string BPDiastolicRange = "Diastolic range should be between 1mmHg and 250mmHg";
        public const string BPElavated = "Blood pressure elevated";
        public const string BPHypertensionStage1 = "High blood pressure (Hypertension) Stage 1";
        public const string BPHypertensionStage2 = "High blood pressure (Hypertension) Stage 2";
        public const string BPHypertensionCrisis = "Hypertension crisis (Consult doctor immediately)";

        //MEDICAL ENCOUNTER
        public const string DrugTypeRequired = "Required!";
        public const string DrugTypeInvalidEntry = "Invalid input!";
        public const string AllergiesRequired = "Required!";
        public const string AllergiesInvalidEntry = "Invalid input!";

        //ANC
        public const string LMPIsFutureDate = "Last menstrual period cannot be a future date";
        public const string EDDDateLessThanLMPDate = "Expected delivery date cannot be less than LMP date";

        //HTS
        public const string ClientAlreadyOnART = "Client is already on ART. HTS record(s) can not be captured!";
        public const string DeterminedDateRequired = "Determined date is required!";
        public const string DeterminedResultRequired = "Determine result is required!";
        public const string UniGoldDateRequired = "Uni Gold date is required!";
        public const string UniGoldResultRequired = "Uni Gold result is required!";
        public const string DNAPCRDateRequired = "DNA PCR date is required!";
        public const string DNAPCRResultRequired = "DNA PCR result is required!";
        public const string ReTestDateRequired = "Re-test date is required!";
        public const string TestTypeRequired = "Test Type is required!";
        public const string TestModalityRequired = "Test Modality is required!";
        public const string IndexCodeRequired = "Index Code is required!";

        public const string IndexCodeInvalid = "Invalid index code!";

        //IMMUNIZATION
        public const string ImmunizationTypeRequired = "Required!";

        //PRESCRIPTION
        public const string EstimatedAvailabilityDateIsPastDate = "Date cannot be historic!";
    }
}
