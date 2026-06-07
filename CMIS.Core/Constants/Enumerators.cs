using System.ComponentModel.DataAnnotations;

namespace CMIS.Core.Constants
{
    public class Enumerators
    {
        public enum YesNo : byte
        {
            Yes = 1,
            No = 2
        }

        public enum DrugType : byte
        {
            Penicillin = 1,
            Other = 2
        }

        public enum PNCPlaceOfDelivery : byte
        {
            Hospital = 1,
            Home = 2
        }

        public enum HIVStatus : byte
        {
            Positive = 1,
            Negative = 2,
            Unknown = 3
        }

        public enum DNAPCRHIVStatus : byte
        {
            Positive = 1,
            Negative = 2,
            [Display(Name = "Not done")]
            NotDone = 3
        }

        public enum PreviousHIVTestResult : byte
        {
            Reactive = 1,

            [Display(Name = "Non-Reactive")]
            NonReactive = 2,

            Inconclusive = 3
        }

        public enum HIVTestResult : byte
        {
            Reactive = 1,

            [Display(Name = "Non-reactive")]
            NonReactive = 2,

            //Inconclusive = 3,

            [Display(Name = "Not done")]
            NotDone = 3
        }

        public enum TestType : byte
        {
            [Display(Name = "New Test")]
            NewTest = 1,

            [Display(Name = "Re-Test")]
            ReTest = 2,

            Confirmatory = 3,

            Verification = 4
        }

        public enum TestModality : byte
        {
            [Display(Name = "Birth Testing")]
            BirthTesting = 1,

            CIHTC = 2,

            [Display(Name = "HIVST-Assisted")]
            HIVSTAssisted = 3,

            [Display(Name = "HIVST-Un-Assisted")]
            HIVSTUnAssisted = 4,

            [Display(Name = "Index Testing")]
            IndexTesting = 5,

            PEP = 6,

            PIHTC = 7,

            PrEP = 8,

            Verification = 9
        }

        public enum ShoeSearchResultPanel : byte
        {
            Hide = 0,
            Show = 1
        }

        public enum TBScreeningResults : byte
        {
            Positive = 1,
            Negative = 0
        }

        public enum Sex : byte
        {
            Male = 1,
            Female = 2,
            Unknown = 3
        }

        public enum MaritalStatus : byte
        {
            Single = 1,
            Married = 2,
            Widowed = 3,
            Divorced = 4,
            Separated = 5
        }

        public enum RelationshipType : byte
        {
            Wife = 1,
            Husband = 2,
            Daughter = 3,
            Son = 4,
            Mother = 5,
            Father = 6,
            Brother = 7,
            Sister = 8,
            Aunt = 9,
            Uncle = 10,
            [Display(Name = "Grand mother")]
            GrandMother = 11,
            [Display(Name = "Grand father")]
            GrandFather = 12,
            Friend = 13,
            Cousin = 14,
            [Display(Name = "Grand daughter")]
            GrandDaughter = 15,
            [Display(Name = "Grand son")]
            GrandSon = 16,
            Partner = 17,
            [Display(Name = "Brother in law")]
            BrotherInLaw = 18,
            [Display(Name = "Sister in law")]
            SisterInLaw = 19
        }

        public enum RowStatus : byte
        {
            Deleted = 0,
            Active = 1,
            Inactive = 2,
            Archived = 3
        }

        public enum RowSyncStatus : byte
        {
            Synced = 0,
            NotSynced = 1
        }

        public enum FPStatus : int
        {
            [Display(Name = "New Acceptor")]
            NewAcceptor = 1,

            [Display(Name = "Re-Attendance")]
            ReAttendance = 2
        }

        public enum FacilityServicePoints : int
        {
            Vitals = 1,

            [Display(Name = "TB Screening")]
            TBScreening = 2,

            HTS = 3,

            [Display(Name = "Medical Encounter")]
            MedicalEncounter = 4,

            ART = 5,

            [Display(Name = "TB (DS)")]
            TBDS = 6,

            [Display(Name = "TB (DR)")]
            TBDR = 7,

            Laboratory = 8,

            ANC = 9,

            PNC = 10,

            [Display(Name = "Child Welfare")]
            ChieldWelfare = 11,

            [Display(Name = "Family Planning")]
            FamilyPlanning = 12,

            [Display(Name = "Cervical Cancer")]
            CervicalCancer = 13,

            Maternity = 14,

            VMMC = 15,

            [Display(Name = "In Patient")]
            InPatient = 16,

            Prescription = 17,

            [Display(Name = "Palliative Care")]
            PalliativeCare = 18,

            Referral = 19,

            Immunization = 20
        }

        public enum SeverityGrade : byte
        {
            Mild = 1,
            Moderate = 2,
            Severe = 3
        }

        public enum PatientCategory : byte
        {
            [Display(Name = "Drug Susceptible (DS)")]
            DrugSusceptible = 1,
            [Display(Name = "Drug Resistant (DR)")]
            DrugResistance = 2
        }

        public enum PAPSmearResult : byte
        {
            [Display(Name = "Not done")]
            NotDone = 1,
            Positive = 2,
            Negative = 3,
            [Display(Name = "Suspicious Of Cancer")]
            SuspiciousOfCancer = 4,
            [Display(Name = "Not applicable")]
            NotApplicable = 5
        }

        public enum VIAResult : byte
        {
            [Display(Name = "Not done")]
            NotDone = 1,
            Positive = 2,
            Negative = 3,
            [Display(Name = "Suspicious Of Cancer")]
            SuspiciousOfCancer = 4,
            [Display(Name = "Not applicable")]
            NotApplicable = 5
        }

        public enum SexOfBaby : byte
        {
            Male = 1,
            Female = 2,
            Unspecified = 3
        }

        public enum AdverseEventStatu : byte
        {
            OnGoing = 1,
            Recovered = 2
        }

        public enum MedicationForm : byte
        {
            Tablet = 1,
            Capsule = 2,
            Syrup = 3,
            Injection = 4,
            Powder = 5
        }

        public enum Region : byte
        {
            Hhohho = 1,
            Manzini = 2,
            Shiselweni = 3,
            Lubombo = 4
        }

        public enum ReferralTypes : byte
        {
            [Display(Name = "Referral within")]
            ReferralWithin = 1,
            [Display(Name = "Facility to facility")]
            FacilityToFacility = 2,
            [Display(Name = "Facility to community")]
            FacilityToCommunity = 3
        }

        public enum AdmissionType : byte
        {
            [Display(Name = "Normal hours - Emergency")]
            NormalHoursEmergency = 1,

            [Display(Name = "Normal hours - Non Emergency")]
            NormalHoursNonEmergency = 2,

            [Display(Name = "After hours - Emergency")]
            AfterHoursEmergency = 3,

            [Display(Name = "After hours - Non Emergency")]
            AfterHoursNonEmergency = 4,

            [Display(Name = "Elective surgery - Planned")]
            ElectiveSurgeryPlanned = 5,

            [Display(Name = "Elective surgery - Unplanned")]
            ElectiveSurgeryUnplanned = 6
        }

        public enum IndexModule : int
        {
            TBDS = 1,
            TBDR = 2
        }

        public enum Tinkhudla : int
        {
            Inkhundla1 = 1,
            Inkhundla2 = 2,
            Inkhundla3 = 3
        }

        public enum FunctionalStatus : byte
        {
            Working = 1,
            Ambulant = 2,
            [Display(Name = "Bed Ridden")]
            BedRidden = 3,
            [Display(Name = "Client is a baby")]
            ClientIsABaby = 4
        }

        public enum Country : int
        {
            [Display(Name = "Kingdom of Eswatini")]
            KingdomOfEswatini = 1,

            Afghanistan = 2,
            Albania = 3,
            Algeria = 4,
            Andorra = 5,
            Angola = 6,

            [Display(Name = "Antiguana and Barbuda")]
            AntiguaAndBarbuda = 7,

            Argentina = 8,
            Armenia = 9,
            Australia = 10,
            Austria = 11,
            Azerbaijan = 12,
            Bahamas = 13,
            Bahrain = 14,
            Bangladesh = 15,
            Barbados = 16,
            Belarus = 17,
            Belgium = 18,
            Belize = 19,
            Benin = 20,
            Bhutan = 21,
            Bolivia = 22,
            Botswana = 23,
            Brazil = 24,
            Brunei = 25,
            Bulgaria = 26,

            [Display(Name = "Burkina Faso")]
            BurkinaFaso = 27,
            Burundi = 28,

            [Display(Name = "Cabo Verde")]
            CaboVerde = 29,
            Cambodia = 30,
            Cameroon = 31,
            Canada = 32,

            [Display(Name = "Central African Republic")]
            CentralAfricanRepublic = 33,
            Chad = 34,
            Chile = 35,
            China = 36,
            Colombia = 37,
            Comoros = 38,

            [Display(Name = "Democratic Republic of Congo")]
            DemocraticRepublicOfCongo = 39,

            [Display(Name = "Costa Rica")]
            CostaRica = 40,

            [Display(Name = "Cote d'Ivoire")]
            CotedIvoire = 41,
            Croatia = 42,
            Cuba = 43,
            Cyprus = 44,

            [Display(Name = "Czech Republic")]
            CzechRepublic = 45,
            Denmark = 46,
            Djibouti = 47,
            Dominica = 48,

            [Display(Name = "Dominican Republic")]
            DominicanRepublic = 49,
            Ecuador = 50,
            Egypt = 51,

            [Display(Name = "El Salvador")]
            ElSalvador = 52,

            [Display(Name = "Equatorial Guinea")]
            EquatorialGuinea = 53,
            Eritrea = 54,
            Estonia = 55,
            Ethiopia = 56,
            Fiji = 57,
            Finland = 58,
            France = 59,
            Gabon = 60,
            Gambia = 61,
            Georgia = 62,
            Germany = 63,
            Ghana = 64,
            Greece = 65,
            Grenada = 66,
            Guatemala = 67,
            Guinea = 68,

            [Display(Name = "Guinea Bissau")]
            GuineaBissau = 69,
            Guyana = 70,
            Haiti = 71,
            Honduras = 72,
            Hungary = 73,
            Iceland = 74,
            India = 75,
            Indonesia = 76,
            Iran = 77,
            Iraq = 78,
            Ireland = 79,
            Israel = 80,
            Italy = 81,
            Jamaica = 82,
            Japan = 83,
            Jordan = 84,
            Kazakhstan = 85,
            Kenya = 86,
            Kiribati = 87,
            Kosovo = 88,
            Kuwait = 89,
            Kyrgyzstan = 90,
            Laos = 91,
            Latvia = 92,
            Lebanon = 93,
            Lesotho = 94,
            Liberia = 95,
            Libya = 96,
            Liechtenstein = 97,
            Lithuania = 98,
            Luxembourg = 99,
            Macedonia = 100,
            Madagascar = 101,
            Malawi = 102,
            Malaysia = 103,
            Maldives = 104,
            Mali = 105,
            Malta = 106,

            [Display(Name = "Marshall Islands")]
            MarshallIslands = 107,
            Mauritania = 108,
            Mauritius = 109,
            Mexico = 110,
            Micronesia = 111,
            Moldova = 112,
            Monaco = 113,
            Mongolia = 114,
            Montenegro = 115,
            Morocco = 116,
            Mozambique = 117,
            Myanmar = 118,
            Namibia = 119,
            Nauru = 120,
            Nepal = 121,
            Netherlands = 122,

            [Display(Name = "New Zealand")]
            NewZealand = 123,
            Nicaragua = 124,
            Niger = 125,
            Nigeria = 126,

            [Display(Name = "North Korea")]
            NorthKorea = 127,
            Norway = 128,
            Oman = 129,
            Pakistan = 130,
            Palau = 131,
            Palestine = 132,
            Panama = 133,

            [Display(Name = "Papua New Guinea")]
            PapuaNewGuinea = 134,
            Paraguay = 135,
            Peru = 136,
            Philippines = 137,
            Poland = 138,
            Portugal = 139,
            Qatar = 140,
            Romania = 141,
            Russia = 142,
            Rwanda = 143,

            [Display(Name = "Saint Lucia")]
            SaintLucia = 144,
            Samoa = 145,

            [Display(Name = "San Marino")]
            SanMarino = 146,

            [Display(Name = "Saudi Arabia")]
            SaudiArabia = 147,
            Senegal = 148,
            Serbia = 150,
            Seychelles = 151,

            [Display(Name = "Sierra Leone")]
            SierraLeone = 152,
            Singapore = 153,
            Slovakia = 154,
            Slovenia = 155,

            [Display(Name = "Solomon Island")]
            SolomonIslands = 156,
            Somalia = 157,

            [Display(Name = "South Africa")]
            SouthAfrica = 158,

            [Display(Name = "South Korea")]
            SouthKorea = 159,

            [Display(Name = "South Sudan")]
            SouthSudan = 160,
            Spain = 161,

            [Display(Name = "Sri Lanka")]
            SriLanka = 162,
            Sudan = 163,
            Suriname = 164,
            Sweden = 165,
            Switzerland = 166,
            Syria = 167,
            Taiwan = 168,
            Tajikistan = 169,
            Tanzania = 170,
            Thailand = 171,

            [Display(Name = "Timor Leste")]
            TimorLeste = 172,
            Togo = 173,
            Tonga = 174,

            [Display(Name = "Trinida and Tobago")]
            TrinidadAndTobago = 175,
            Tunisia = 176,
            Turkey = 177,
            Turkmenistan = 178,
            Tuvalu = 179,
            Uganda = 180,
            Ukraine = 181,

            [Display(Name = "United Arab Emirates")]
            UnitedArabEmirates = 182,

            [Display(Name = "United Kingdom")]
            UnitedKingdom = 183,

            [Display(Name = "United States of America")]
            UnitedStatesofAmerica = 184,
            Uruguay = 185,
            Uzbekistan = 186,
            Vanuatu = 187,

            [Display(Name = "Vatican City")]
            VaticanCity = 188,
            Venezuela = 189,
            Vietnam = 190,
            Yemen = 191,
            Zambia = 192,
            Zimbabwe = 193
        }

        public enum UserType : byte
        {
            GeneralUser = 1,
            Administrator = 2,
            HMISAnalyst = 3,
            FacilityChampion = 4
        }

        public enum VisitType : byte
        {
            [Display(Name = "First Visit")]
            FirstVisit = 1,

            [Display(Name = "Re-Visit")]
            ReVisit = 2
        }
    }
}
