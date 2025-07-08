using ISCore.Resources;
using System.ComponentModel.DataAnnotations;
using System.Resources;

namespace ISCore.Enums
{
    public class Enums
    {
        public enum EDKVTerminalStatus:byte
        {
            [Display(Name = "NotActivated", ResourceType = typeof(LocalizationEnum))]
            Neactivat = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activat = 1,
            [Display(Name = "Deactivated", ResourceType = typeof(LocalizationEnum))]
            Dezactivat = 2,
            [Display(Name = "Terminated", ResourceType = typeof(LocalizationEnum))]
            Reziliat = 3   
        }
        public enum ExecutionResult
        {
            OK = 1,
            KO = 2,
            ERROR = 3,
            NOTVALID = 4,
            EXCEPTION = 5,
            LOGOUT = 6,
        }

        public enum EnUiLanguage
        {
            EN = 0,
            RO = 1,
            RU = 2,
        }

        public enum ECompanyStatus
        {
            [Display(Name = "NewRegistered", ResourceType = typeof(LocalizationEnum))]
            NewRegistered = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Active = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
        }

        public enum EUserStatus
        {
            [Display(Name = "NewRegistered", ResourceType = typeof(LocalizationEnum))]
            NewRegistered = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Active = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
        }

        public enum EnProductLicenseType
        {
            Free = 0,
            LicenseList = 1,
            ApyKey = 2,
            Users = 3,
            ActiveDirectoryUsers = 4,
            FiscalDeviceList = 5,
            KeyUsers = 6,

        }

        public enum EnProduct
        {
            SalesExpert = 1,
            RestaurantExpert = 2,
            PetrolExpert = 3,
            HotelExpert = 5,
            EDX = 100,
            SMS = 101,
            MyDiscount = 102,
            Mail = 103,
            QIWI = 104,
            Fiscal = 105,
            Paynet = 106,
            Paynet_payment_card_or_wallet = 107,
            QuickPay = 108,
            QRPassEntry = 109,
            EWallet = 110,
            Payment_aggregator = 111,
            EmailSMSMarketing = 200,
            CloudSalesExpert = 201,
            AccountingExpert = 202,
            CloudRestaurantExpert = 203,
            CloudPetrolExpert = 204,
            ElectronicDataInterchange = 205,
            CashRegisters = 299,
            MobileCashRegisters = 300,
            ISPaymentService = 301,
            ISAdminWebApp = 10000,
            ISClientWebApp = 10001,
        }
        public enum EnProductModuleType
        {
            [Display(Name = "NonType", ResourceType = typeof(LocalizationEnum))]
            Non = 0,
            [Display(Name = "AppType", ResourceType = typeof(LocalizationEnum))]
            App = 1,
            [Display(Name = "ServiceType", ResourceType = typeof(LocalizationEnum))]
            Service = 2,
            [Display(Name = "WEBType", ResourceType = typeof(LocalizationEnum))]
            WEB = 3,
            [Display(Name = "MobileType", ResourceType = typeof(LocalizationEnum))]
            Mobile = 4,
        }
        public enum EnProductModule
        {
            NotExist = 0,
            Cash = 1,
            BackOffice = 2,
            MobileAgent = 3,
            MobileStock = 4,
            WarehouseOrderWaitingMonitor = 5,
            MobileWaiter = 6,
            KitchenAssistant = 7,
            OrderWaitingMonitor = 8,
            SelfService = 9,
            ExportService = 100,
            WebExportService = 101,
            Wocomerce = 102,
            FiscalService = 103,
            Controler = 104,
            WebPortalService = 105,
            BusinessIntelligence = 106,
            DBService = 107,
            OnlineOrder = 108,
            PetrolExpertMobileClient = 109,
            PetrolMobileCash = 110,
            Payment_aggregator = 111,
            ECOM = 112,
            EsmSms = 200,
            EsmEmail = 201,
            FiscalService_App = 202,
            FiscalService_Mobile = 203
        }
        public enum EnProductCategory
        {
            [Display(Name = "OnPremiseDesktopApplications", ResourceType = typeof(LocalizationEnum))]
            On_Premise_Desktop_Applications = 0,
            [Display(Name = "SaaSDesktopApplications", ResourceType = typeof(LocalizationEnum))]
            SaaS_Desktop_Applications = 1,
            [Display(Name = "SaaSWebApplications", ResourceType = typeof(LocalizationEnum))]
            SaaS_Web_Applications = 2,
            [Display(Name = "CloudService", ResourceType = typeof(LocalizationEnum))]
            Cloud_Service = 3,
            [Display(Name = "Mobile", ResourceType = typeof(LocalizationEnum))]
            Mobile = 4,
        }
        public enum EnAppStatus
        {
            [Display(Name = "InActive", ResourceType = typeof(LocalizationEnum))]
            InActive = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activate = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
        }
        public enum EnMarketPackageStatus
        {
            [Display(Name = "NewRegistered", ResourceType = typeof(LocalizationEnum))]
            InActive = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activate = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
        }

        public enum EnOperationType
        {
            Sales = 0,
            Refilling = 1,
        }

        public enum EnDisplayType
        {
            Print = 0,
            QR = 1,
            SMS = 2,
            EMail = 3,
        }

        public enum EUnit
        {
            Piece = 0,
            Liter = 1,
            CubicMeter = 2,
            AcpsUnit = 3
        }

        public enum EnFiscalReportType
        {
            RaportZ = 1,
            RaportX = 2,
        }

        public enum EPaymentType
        {
            NUMERAR = 1,
            CARD = 2,
            VAUCHER = 31,
            CEC_CERTIFICAT_VALORIC = 32,
            TICHET = 33,
            TME = 5,
            ABONAMENT = 6,
            ALT_IP = 7,
            CREDIT = 81,
            LEASING = 82,
            AVANS = 83,
            ARVUNA = 84,
            GAJ = 85,
            CARD_VALORIC_CORPORATIV = 86,
            TESTARE_METROLOGICA = 87,
            ALT_MOD = 88,
        }

        public enum EServiceReceiptType
        {
            CashIn = 1,
            CashOut = 2
        }

        public enum Status
        {
            [Display(Name = "ErrorServicesDown", ResourceType = typeof(LocalizationEnum))]
            Error_services_down = -1,
            OK = 0,
            [Display(Name = "ErrorDatabaseConnect", ResourceType = typeof(LocalizationEnum))]
            Error_database_connect = 1,
            [Display(Name = "ErrorMEVConnect", ResourceType = typeof(LocalizationEnum))]
            Error_MEV_connect = 2,
            [Display(Name = "ErrorDatabaseServerConnect", ResourceType = typeof(LocalizationEnum))]
            Error_database_server_connect = 3,
        }

        public enum TraceEventType
        {
            [Display(Name = "Critical", ResourceType = typeof(LocalizationEnum))]
            Critical = 1,
            [Display(Name = "Error", ResourceType = typeof(LocalizationEnum))]
            Error = 2,
            [Display(Name = "Warning", ResourceType = typeof(LocalizationEnum))]
            Warning = 4,
            [Display(Name = "Information", ResourceType = typeof(LocalizationEnum))]
            Information = 8,
            [Display(Name = "Verbose", ResourceType = typeof(LocalizationEnum))]
            Verbose = 16,
            [Display(Name = "Start", ResourceType = typeof(LocalizationEnum))]
            Start = 256,
            [Display(Name = "Stop", ResourceType = typeof(LocalizationEnum))]
            Stop = 512,
            [Display(Name = "Suspend", ResourceType = typeof(LocalizationEnum))]
            Suspend = 1024,
            [Display(Name = "Resume", ResourceType = typeof(LocalizationEnum))]
            Resume = 2048,
            [Display(Name = "Transfer", ResourceType = typeof(LocalizationEnum))]
            Transfer = 4096,
        }

        public enum OSType
        {
            Linux = 0,
            Windows = 1,
        }

        public enum EDBServerState
        {
            [Display(Name = "NotActivated", ResourceType = typeof(LocalizationEnum))]
            Not_activated = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activated = 1,
            [Display(Name = "Blocked", ResourceType = typeof(LocalizationEnum))]
            Blocked = 2,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 3,
        }

        public enum EDBServerType
        {
            PostgreSQL = 0,
            MicrosoftSQL = 1,
            Oracle = 2,
        }

        public enum EnDatabaseState
        {
            [Display(Name = "NewEntity", ResourceType = typeof(LocalizationEnum))]
            New_entity = 0,
            [Display(Name = "CreatingNewDatabase", ResourceType = typeof(LocalizationEnum))]
            Creating_new_database = 1,
            [Display(Name = "NewDatabase", ResourceType = typeof(LocalizationEnum))]
            New_database = 2,
            [Display(Name = "UpdatingSchema", ResourceType = typeof(LocalizationEnum))]
            Updating_schema = 4,
            [Display(Name = "Ready", ResourceType = typeof(LocalizationEnum))]
            Ready = 5,
            [Display(Name = "Maintenance", ResourceType = typeof(LocalizationEnum))]
            Maintenance = 50,
            [Display(Name = "SchemaNeedsToBeUpdated", ResourceType = typeof(LocalizationEnum))]
            Schema_needs_to_be_updated = 101,
            [Display(Name = "Error", ResourceType = typeof(LocalizationEnum))]
            Error = 100,
            [Display(Name = "Recycled", ResourceType = typeof(LocalizationEnum))]
            Recycled = 1000,
        }

        public enum EnServiceState
        {
            [Display(Name = "NewEntity", ResourceType = typeof(LocalizationEnum))]
            New_entity = 0,
            [Display(Name = "ServerIsNotSet", ResourceType = typeof(LocalizationEnum))]
            Server_is_not_set = 1,
            [Display(Name = "Ready", ResourceType = typeof(LocalizationEnum))]
            Ready = 2,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 4,
        }

        public enum EnServices
        {
            NotExist = 0,
            Cash = 1,
            BackOffice = 2,
            MobileAgent = 3,
            MobileStock = 4,
            WarehouseOrderWaitingMonitor = 5,
            MobileWaiter = 6,
            KitchenAssistant = 7,
            OrderWaitingMonitor = 8,
            ExportService = 100,
            WebExportService = 101,
            WooCommerce = 102,
            Controler = 104,
            WebPortalService = 105,
            BusinessIntelligence = 106,
            DBService = 107,
            TransportService = 108,
            ECOM=112,
            ISDatabase = 2000,
        }

        public enum ESystemEmailTemplate
        {
            [Display(Name = "NewUser", ResourceType = typeof(LocalizationEnum))]
            NewUser = 100,
            [Display(Name = "ResetPassword", ResourceType = typeof(LocalizationEnum))]
            ResetPassword = 101
        }

        public enum EnDocumentationStatus
        {
            [Display(Name = "Draft", ResourceType = typeof(LocalizationEnum))]
            Draft = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Active = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
            [Display(Name = "Deleted", ResourceType = typeof(LocalizationEnum))]
            Delete = 3,
        }

        public enum EClientCardPosItemStatus
        {
            Active = 0,
            Disabled = 1,
        }

        public enum EStateCompanyInfo
        {
            [Display(Name = "Indeterminate", ResourceType = typeof(LocalizationEnum))]
            Indeterminate = -1,
            [Display(Name = "IsOK", ResourceType = typeof(LocalizationEnum))]
            IsOK = 0,
            [Display(Name = "Warning", ResourceType = typeof(LocalizationEnum))]
            Warning = 1,
            [Display(Name = "Blocked", ResourceType = typeof(LocalizationEnum))]
            Blocked = 2,
        }

        public enum EnTicketStatus
        {
            [Display(Name = "Nothing", ResourceType = typeof(LocalizationEnum))]
            Nothing = -1,
            [Display(Name = "New", ResourceType = typeof(LocalizationEnum))]
            New = 0,
            [Display(Name = "Viewed", ResourceType = typeof(LocalizationEnum))]
            Viewed = 1,
            [Display(Name = "InProgress", ResourceType = typeof(LocalizationEnum))]
            In_progress = 2,
            [Display(Name = "Fixed", ResourceType = typeof(LocalizationEnum))]
            Fixed = 3,
            [Display(Name = "Closed", ResourceType = typeof(LocalizationEnum))]
            Closed = 4,
            [Display(Name = "Reopen", ResourceType = typeof(LocalizationEnum))]
            Reopen = 5,
            [Display(Name = "Rejected", ResourceType = typeof(LocalizationEnum))]
            Rejected = 6,
        }
        public enum EnTicketType
        {
            Public = 0,
            Interal = 1,
        }

        public enum EnVersionStatus
        {
            [Display(Name = "Approved", ResourceType = typeof(LocalizationEnum))]
            Approved = 0,
            [Display(Name = "Rejected", ResourceType = typeof(LocalizationEnum))]
            Rejected = 1,
            [Display(Name = "Testing", ResourceType = typeof(LocalizationEnum))]
            Testing = 2,
        }

        public enum EnReproducibility
        {
            [Display(Name = "Constantly", ResourceType = typeof(LocalizationEnum))]
            Constantly = 0,
            [Display(Name = "Periodically", ResourceType = typeof(LocalizationEnum))]
            Periodically = 1,
            [Display(Name = "Rarely", ResourceType = typeof(LocalizationEnum))]
            Rarely = 2,
            [Display(Name = "Impossible", ResourceType = typeof(LocalizationEnum))]
            Impossible = 3,
        }

        public enum EnTicketCategory
        {
            [Display(Name = "Bug", ResourceType = typeof(LocalizationEnum))]
            Bug = 0,
            [Display(Name = "Issues", ResourceType = typeof(LocalizationEnum))]
            Issues = 1,
            [Display(Name = "Suggestion", ResourceType = typeof(LocalizationEnum))]
            Suggestion = 2,
        }

        public enum EnEditState
        {
            No = 0,
            Change = 1,
            Deleted = 2,
        }

        public enum EnSecurityPermissionState
        {
            [Display(Name = "Deny", ResourceType = typeof(LocalizationEnum))]
            Deny = 0,
            [Display(Name = "ReadOnly", ResourceType = typeof(LocalizationEnum))]
            Read_only = 1,
            [Display(Name = "Allow", ResourceType = typeof(LocalizationEnum))]
            Allow = 2,
        }

        public enum AdminLinks
        {
            Dashboard = 1,
            Application = 2,
            Company = 3,
            User = 4,
            Templates = 5,
            ManagementServer = 6,
            ManagementDatabase = 7,
            ManagementService = 8,
            Map = 9,
            MapSettings = 10,
            BugTracker = 11,
            Versions = 12,
            Documentation = 13,
            Group = 14,
            Diagnostic = 15,
            Events = 16,
            Configuration = 17,
            ErrorBills = 18,
            ReportTemplate = 19,
            ProductsOrServices = 20,
            Invoice = 21,
            AppEvents = 22,
            Contract = 23,
            Banks = 24,
        }

        public enum EnConfigurationService
        {
            Authentication_Service = 1,
            AdminWebApp_Service = 2,
            ClientWebApp_Service = 3,
            AD_Service = 4,
            CloudServiceManager_Service = 5,
            Database_Service = 6,
            License_Service = 7,
            CallBack_Service = 8,
            SupportCenter_Service = 9,
            CloudSystemDiagnostic_Service = 10,
            EDXWindows_Service = 11,
            EDXWorker_Service = 12,
            FiscalCloudRegister_Service = 13,
            FiscalCloud_Service = 14,
            FiscalCloudWorker_Service = 15,
            MobileCashRegister_Service = 16,
            IQOS_Service = 17,
            Mail_Service = 18,
            MailWorker_Service = 19,
            Discount_Service = 20,
            MyDiscount_Service = 21,
            Paynet_Service = 22,
            QIWI_Service = 23,
            SMS_Service = 24,
            SMSWorker_Service = 25,
            ISFiscalCloudSync_Service = 26,
            ISCloudSMS = 27,
            QuickPay = 28,
            FiscalCloudManagement = 29,
            CloudManagement = 30,
            MyDiscount_APP = 31,
            Fiscal_cloud_service_API = 32,
            Payments_service = 33,
            ISFiscalCloudServiceDevice = 34,
            ISFiscalCloudServiceWEB = 35,
            Fiscal_cloud_service_IOT = 36,
            Config_manager_service_API = 37,
            NpsAPI = 38,
            Fiscal_cloud_MEV = 39,
            FiscalDataPattern = 40,
            ISFiscalCloudTaxi = 41,
            QRPassEntry = 42,
            IQOS_Web = 3000,
        }

        public enum MobileCashRegisterType
        {
            CashRegister = 0,
            PaymentTerminal = 1,
            CashRegisterService = 2,
        }

        public enum EnIntsallationPlatform
        {
            Nothing = 0,
            Windows = 1,
            Android = 2,
            iOS = 3,
            Linux = 4
        }

        public enum EnLicenseStatus
        {
            [Display(Name = "NotActivated", ResourceType = typeof(LocalizationEnum))]
            NotActivated = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activated = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
        }

        public enum EnNotificationType
        {
            Informational = 0,
            Advertising = 1,
            Warning = 2,
        }

        public enum EFiscalDeviceStatus
        {
            [Display(Name = "NotActivated", ResourceType = typeof(LocalizationEnum))]
            NotActivated = 0,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activated = 1,
            [Display(Name = "Disabled", ResourceType = typeof(LocalizationEnum))]
            Disabled = 2,
            [Display(Name = "Erased", ResourceType = typeof(LocalizationEnum))]
            Erased = 3,
        }

        public enum FiscalDeviceType
        {
            [Display(Name = "NotFiscal", ResourceType = typeof(LocalizationEnum))]
            NotFiscal = 0,
            SI_DE_imprimante_fiscale = 1,
            SI_DE_fara_imprimante_fiscale = 2,
            SI_FDE_fara_imprimante_fiscale = 3,
            Masina_de_casa_si_control = 4,
        }

        public enum EMEVVersion
        {
            V1 = 0,
            V2 = 1,
        }

        public enum EBusinessType
        {
            [Display(Name = "NotSet", ResourceType = typeof(LocalizationEnum))]
            NotSet = 0,
            Petrol = 1,
            Sales = 2,
            PetrolAndSales = 3,
            Taxi = 4,
            [Display(Name = "Gambling", ResourceType = typeof(LocalizationEnum))]
            Gambling = 5,
        }

        public enum TypeObject
        {
            [Display(Name = "FiscalReceipt", ResourceType = typeof(LocalizationEnum))]
            FiscalReceipt = 0,
            [Display(Name = "FiscalReport", ResourceType = typeof(LocalizationEnum))]
            FiscalReport = 1,
            [Display(Name = "ServiceReceipt", ResourceType = typeof(LocalizationEnum))]
            ServiceReceipt = 2,
        }

        public enum EnSettings
        {
            [Display(Name = "Setting1", ResourceType = typeof(LocalizationEnum))]
            S1 = 1,
            [Display(Name = "Setting2", ResourceType = typeof(LocalizationEnum))]
            S2 = 2,
            [Display(Name = "Setting3", ResourceType = typeof(LocalizationEnum))]
            S3 = 3,
        }

        public enum ECampaignStatus
        {
            Draft = 0,
            Scheduled = 1,
            Instant = 2,
        }

        public enum EMonth
        {
            [Display(Name = "January", ResourceType = typeof(LocalizationEnum))]
            January = 1,
            [Display(Name = "February", ResourceType = typeof(LocalizationEnum))]
            February = 2,
            [Display(Name = "March", ResourceType = typeof(LocalizationEnum))]
            March = 3,
            [Display(Name = "April", ResourceType = typeof(LocalizationEnum))]
            April = 4,
            [Display(Name = "May", ResourceType = typeof(LocalizationEnum))]
            May = 5,
            [Display(Name = "June", ResourceType = typeof(LocalizationEnum))]
            June = 6,
            [Display(Name = "July", ResourceType = typeof(LocalizationEnum))]
            July = 7,
            [Display(Name = "August", ResourceType = typeof(LocalizationEnum))]
            August = 8,
            [Display(Name = "September", ResourceType = typeof(LocalizationEnum))]
            September = 9,
            [Display(Name = "October", ResourceType = typeof(LocalizationEnum))]
            October = 10,
            [Display(Name = "November", ResourceType = typeof(LocalizationEnum))]
            November = 11,
            [Display(Name = "December", ResourceType = typeof(LocalizationEnum))]
            December = 12,
        }
        public enum EPaymentPlatform
        {
            Not_set = 0,
            tapXphone = 1,
            AshburnVB = 2,
            DKV = 3,
            PAX = 4,
            SmartOne = 5,
            ISEasyPay = 6,
            Ingenico = 7,
            AshburnMAIB = 8
        }

        public enum LogType
        {
            Critical = 1, //Fatal error or application crash
            Error = 2, //Recoverable error
            Warning = 4, //Noncritical problem
            Information = 8 //Informational message
        }

        public enum EnMIAPaymentPlatform
        {
            NA=0,
            BPay_MIA = 1,
            Paynet_MIA = 2,
            QiWi_MIA = 3,
            Paynet_CARD = 100,
            MAIB_Card = 101,
            QR = 1000,
        }

        public enum EnServiceProvider
        {
            StartNet = 1,
        }

        public enum EnAbsenceType
        {
            [Display(Name = "WorkPurposeAbsence", ResourceType = typeof(LocalizationEnum))]
            Work_purpose_absence = 1,
            [Display(Name = "Sickness", ResourceType = typeof(LocalizationEnum))]
            Sickness = 2,
            [Display(Name = "PersonalReasonsAbsence", ResourceType = typeof(LocalizationEnum))]
            Personal_reasons_absence = 3,
            [Display(Name = "AnnualLeave", ResourceType = typeof(LocalizationEnum))]
            Annual_leave = 4,
            [Display(Name = "AdvanceLeave", ResourceType = typeof(LocalizationEnum))]
            Early_absence_from_annual_leave = 5
        }

        public enum EnFilterFDevice
        {
            [Display(Name = "NewRegister", ResourceType = typeof(LocalizationEnum))]
            NewRegister = 0,
            [Display(Name = "Fiscalized", ResourceType = typeof(LocalizationEnum))]
            Fiscalized = 1,
            [Display(Name = "Activated", ResourceType = typeof(LocalizationEnum))]
            Activ = 2,
            [Display(Name = "All", ResourceType = typeof(LocalizationEnum))]
            All = 3

        }

        public enum WorkstationCount : byte
        {
            [Display(Name = "Contract_Back", ResourceType = typeof(LocalizationEnum))]
            Back = 1,
            [Display(Name = "Contract_Casa", ResourceType = typeof(LocalizationEnum))]
            Case = 2,
        }

        public enum OurServer : byte
        {
            [Display(Name = "Contract_Our", ResourceType = typeof(LocalizationEnum))]
            Our = 1,
            [Display(Name = "Contract_Client", ResourceType = typeof(LocalizationEnum))]
            Client = 2,
        }

        public enum TopBusinessProcesses : byte
        {
            [Display(Name = "Contract_Import", ResourceType = typeof(LocalizationEnum))]
            Import = 1,
            [Display(Name = "Contract_Production", ResourceType = typeof(LocalizationEnum))]
            Production = 2,
            [Display(Name = "Contract_Sale", ResourceType = typeof(LocalizationEnum))]
            Sale = 3,
            [Display(Name = "Contract_Export", ResourceType = typeof(LocalizationEnum))]
            Export = 4,
            [Display(Name = "Contract_Another", ResourceType = typeof(LocalizationEnum))]
            Another = 5,
        }
        public enum Version1C : byte
        {
            [Display(Name = "Contract_7x", ResourceType = typeof(LocalizationEnum))]
            _7x = 1,
            [Display(Name = "Contract_8x", ResourceType = typeof(LocalizationEnum))]
            _8x = 2,
        }
        public enum CustomerEquipment : byte
        {
            [Display(Name = "Contract_CashRegisters", ResourceType = typeof(LocalizationEnum))]
            CashRegisters = 1,
            [Display(Name = "Contract_FiscalPrinters", ResourceType = typeof(LocalizationEnum))]
            FiscalPrinters = 2,
            [Display(Name = "Contract_BarcodeScanners", ResourceType = typeof(LocalizationEnum))]
            BarcodeScanners = 3,
            [Display(Name = "Contract_POSPrinters", ResourceType = typeof(LocalizationEnum))]
            POSPrinters = 4,
            [Display(Name = "Contract_POSLabelPrinters", ResourceType = typeof(LocalizationEnum))]
            POSLabelPrinters = 5,
            [Display(Name = "Contract_TSD", ResourceType = typeof(LocalizationEnum))]
            TSD = 6,
            [Display(Name = "Contract_Scales", ResourceType = typeof(LocalizationEnum))]
            Scales = 7,
            [Display(Name = "Contract_CashDrawers", ResourceType = typeof(LocalizationEnum))]
            CashDrawers = 8,
            [Display(Name = "Contract_BuyerMonitors", ResourceType = typeof(LocalizationEnum))]
            BuyerMonitors = 9,
            [Display(Name = "Contract_FrontOfficeComputers", ResourceType = typeof(LocalizationEnum))]
            FrontOfficeComputers = 10,
            [Display(Name = "Contract_BackOfficeComputers", ResourceType = typeof(LocalizationEnum))]
            BackOfficeComputers = 11,
            [Display(Name = "Contract_ServerEquipment", ResourceType = typeof(LocalizationEnum))]
            ServerEquipment = 12,
        }
        public enum ImprovementType : byte
        {
            [Display(Name = "Contract_FunctionalShortcomings", ResourceType = typeof(LocalizationEnum))]
            FunctionalShortcomings = 1,
            [Display(Name = "Contract_InterfaceFlaws", ResourceType = typeof(LocalizationEnum))]
            InterfaceFlaws = 2,
            [Display(Name = "Contract_ProductiveShortcomings", ResourceType = typeof(LocalizationEnum))]
            ProductiveShortcomings = 3,
        }
        public enum ExistingorOptionalEquipment : byte
        {
            Existing = 1,
            Optional = 2,
        }
        public enum Priority : byte
        {
            [Display(Name = "Priority_High", ResourceType = typeof(LocalizationEnum))]
            High = 1,
            [Display(Name = "Priority_Low", ResourceType = typeof(LocalizationEnum))]
            Low = 2,
            [Display(Name = "Priority_Normal", ResourceType = typeof(LocalizationEnum))]
            Normal = 3,
        }

        public enum Project_Automation_Type : byte
        {
            SalesExpert = 1,
            RestaurantExpert = 2,
            PetrolExpert = 3,
            HotelExpert = 4,
            MedicalExpert = 5,
        }
        public enum Project_Status : byte
        {
            [Display(Name = "Priority_Not_started", ResourceType = typeof(LocalizationEnum))]
            Not_started = 1,
            [Display(Name = "Priority_In_progress", ResourceType = typeof(LocalizationEnum))]
            In_progress = 2,
            [Display(Name = "Priority_Completed", ResourceType = typeof(LocalizationEnum))]
            Completed = 3,
            [Display(Name = "Priority_Postponed", ResourceType = typeof(LocalizationEnum))]
            Postponed = 4
        }
        public enum EnumBank : byte
        {
            MAIB = 1,
            Moldindconbank = 2,
        }

        public enum EnDeviceType
        {
            None=0,
            VictoriaBank = 1,
            MAIB=2,
            Moldinconbank= 3,
            OTP_Mobiasbanca=4,
            Fincombank=5,
            iOS_Android_Personal_Smartphone =100,
            Feitian=102,
            Vending_machine_with_integrated_Feitian=103,
            Vending_IoT_Machine=104,
            Web=105
        }

        public enum EnDeviceTypeCR
        {
            Not_set = 0,
            Retail = 1,
            Retail_self_service = 2,
            Restaurant = 3,
            Restaurant_self_service = 4,

        }

        public enum EnOSTypeCR
        {
            NA = -1,
            Linux = 0,
            Windows = 1,
            Android = 2,
        }
    }

    public static class EnumHelper
    {
        public static string GetLocalizedValue(Enum enumValue)
        {
            var displayAttribute = enumValue.GetType()
                .GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(DisplayAttribute), false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            if (displayAttribute != null)
            {
                ResourceManager resourceManager = new ResourceManager(displayAttribute.ResourceType);
                string localizedValue = resourceManager.GetString(displayAttribute.Name);

                if (!string.IsNullOrEmpty(localizedValue))
                {
                    return localizedValue;
                }
            }
            return enumValue.ToString();
        }
    }

}
