using ISCore.Resources;
using System.ComponentModel.DataAnnotations;

namespace ISCore.Enums
{
    public enum EnErrorCode
    {
        [Display(Name = "InternalError", ResourceType = typeof(LocalizationEnum))]
        Internal_error = -1,
        [Display(Name = "NoError", ResourceType = typeof(LocalizationEnum))]
        NoError = 0,
        [Display(Name = "CompanyNotFound", ResourceType = typeof(LocalizationEnum))]
        Company_not_found = 1,
        [Display(Name = "UserNameOrPasswordIsIncorrect", ResourceType = typeof(LocalizationEnum))]
        User_name_or_password_is_incorrect = 2,
        [Display(Name = "IntsallationPlatformNotExist", ResourceType = typeof(LocalizationEnum))]
        Intsallation_platform_not_exist = 3,
        [Display(Name = "ApplicationNotAvailable", ResourceType = typeof(LocalizationEnum))]
        Application_not_available = 4,
        [Display(Name = "InstallationIdNotFound", ResourceType = typeof(LocalizationEnum))]
        Installation_id_not_found = 5,
        [Display(Name = "InstallationIdNotValid", ResourceType = typeof(LocalizationEnum))]
        Installation_id_not_valid = 6,
        [Display(Name = "APIKeyNotExist", ResourceType = typeof(LocalizationEnum))]
        APIKey_not_exist = 10,
        [Display(Name = "InsufficientFunds", ResourceType = typeof(LocalizationEnum))]
        Insufficient_funds = 100,
        [Display(Name = "RecipientIsNotRegistered", ResourceType = typeof(LocalizationEnum))]
        Recipient_is_not_registered = 101,
        [Display(Name = "UserNameNotFoundOrIncorrectPassword", ResourceType = typeof(LocalizationEnum))]
        User_name_not_found_or_incorrect_password = 102,
        [Display(Name = "UserDisabled", ResourceType = typeof(LocalizationEnum))]
        User_Disabled = 103,
        [Display(Name = "UserAlreadyExists", ResourceType = typeof(LocalizationEnum))]
        User_already_exists = 104,
        [Display(Name = "IncorrectRefreshToken", ResourceType = typeof(LocalizationEnum))]
        Incorrect_refresh_token = 105,
        [Display(Name = "UserNameNotFoundOrIncorrectEmail", ResourceType = typeof(LocalizationEnum))]
        User_name_not_found_or_incorrect_Email = 106,
        [Display(Name = "PhoneNumberAlreadyUsedFromAnotherUser", ResourceType = typeof(LocalizationEnum))]
        Phone_number_already_used_from_another_user = 107,
        [Display(Name = "UserNotActivated", ResourceType = typeof(LocalizationEnum))]
        User_not_activated = 108,
        [Display(Name = "InvalidActivateUserCode", ResourceType = typeof(LocalizationEnum))]
        Invalid_activate_user_code = 109,
        [Display(Name = "UserNotExist", ResourceType = typeof(LocalizationEnum))]
        User_not_exist = 110,
        [Display(Name = "CompanyAlreadyExists", ResourceType = typeof(LocalizationEnum))]
        Company_already_exists = 111,
        [Display(Name = "CompanyDataIsIncorrect", ResourceType = typeof(LocalizationEnum))]
        Company_data_is_incorrect = 112,
        [Display(Name = "NotSetCompany", ResourceType = typeof(LocalizationEnum))]
        Not_set_company = 113,
        [Display(Name = "NotSetEmail", ResourceType = typeof(LocalizationEnum))]
        Not_set_email = 114,
        [Display(Name = "EmailAlreadyUsed", ResourceType = typeof(LocalizationEnum))]
        Email_already_used = 115,
        [Display(Name = "InvalidPasswordData", ResourceType = typeof(LocalizationEnum))]
        Invalid_password_data = 116,
        [Display(Name = "IsNotNewRegistration", ResourceType = typeof(LocalizationEnum))]
        Is_not_new_registration = 117,
        [Display(Name = "InvalidToken", ResourceType = typeof(LocalizationEnum))]
        Invalid_token = 118,
        [Display(Name = "InvalidOldPassword", ResourceType = typeof(LocalizationEnum))]
        Invalid_old_password = 119,
        [Display(Name = "APPNotExist", ResourceType = typeof(LocalizationEnum))]
        APP_not_exist = 120,
        [Display(Name = "MarketPackageNotExist", ResourceType = typeof(LocalizationEnum))]
        MarketPackage_not_exist = 121,
        [Display(Name = "AplicationAlreadyExists", ResourceType = typeof(LocalizationEnum))]
        Aplication_already_exists = 122,
        [Display(Name = "ApplicationNotExist", ResourceType = typeof(LocalizationEnum))]
        Application_not_exist = 123,
        [Display(Name = "LicenseNotExist", ResourceType = typeof(LocalizationEnum))]
        License_not_exist = 124,
        [Display(Name = "ISAuthServiceNotAccessible", ResourceType = typeof(LocalizationEnum))]
        ISAuthService_not_accessible = 125,
        [Display(Name = "ISAuthServiceNotResult", ResourceType = typeof(LocalizationEnum))]
        ISAuthService_not_result = 127,
        [Display(Name = "InvalidCompanyID", ResourceType = typeof(LocalizationEnum))]
        Invalid_Company_ID = 128,
        [Display(Name = "InvalidEmail", ResourceType = typeof(LocalizationEnum))]
        Invalid_Email = 129,
        [Display(Name = "CompanyIDNOAlreadyExists", ResourceType = typeof(LocalizationEnum))]
        Company_IDNO_already_exists = 130,
        [Display(Name = "HttpClientError", ResourceType = typeof(LocalizationEnum))]
        HttpClient_error = 131,
        [Display(Name = "InvalidLicenseActivationCode", ResourceType = typeof(LocalizationEnum))]
        Invalid_license_activation_code = 132,
        [Display(Name = "ApplicationNotActivate", ResourceType = typeof(LocalizationEnum))]
        Application_not_activate = 133,
        [Display(Name = "LicenseNotActivated", ResourceType = typeof(LocalizationEnum))]
        License_not_activated = 134,
        [Display(Name = "HTMLTemplateError", ResourceType = typeof(LocalizationEnum))]
        HTML_template_error = 135,
        [Display(Name = "HTMLTemplateEmpty", ResourceType = typeof(LocalizationEnum))]
        HTML_template_empty = 136,
        [Display(Name = "InvalidPhoneNumber", ResourceType = typeof(LocalizationEnum))]
        Invalid_phone_number = 137,
        [Display(Name = "NewsNotActivate", ResourceType = typeof(LocalizationEnum))]
        News_not_activate = 138,
        [Display(Name = "SMSCampaignNotExist", ResourceType = typeof(LocalizationEnum))]
        SMS_campaign_not_exist = 139,
        [Display(Name = "InvalidExternalSecurityPolicySettings", ResourceType = typeof(LocalizationEnum))]
        Invalid_external_security_policy_settings = 140,
        [Display(Name = "InvalidKeyType", ResourceType = typeof(LocalizationEnum))]
        Invalid_KeyType = 141,
        [Display(Name = "CardNotExist", ResourceType = typeof(LocalizationEnum))]
        Card_not_exist = 142,
        [Display(Name = "ExpiredToken", ResourceType = typeof(LocalizationEnum))]
        Expired_token = 143,
        [Display(Name = "TemporaryKeyDoesNotExist", ResourceType = typeof(LocalizationEnum))]
        Temporary_Key_does_not_exist = 144,
        [Display(Name = "TimeCardIDExpired", ResourceType = typeof(LocalizationEnum))]
        Time_card_ID_expired = 145,
        [Display(Name = "InsufficientAmountOnCard", ResourceType = typeof(LocalizationEnum))]
        Insufficient_amount_on_card = 146,
        [Display(Name = "TheAmountIsIncorrect", ResourceType = typeof(LocalizationEnum))]
        The_amount_is_incorrect = 147,
        [Display(Name = "TransactionNotExist", ResourceType = typeof(LocalizationEnum))]
        Transaction_not_exist = 148,
        [Display(Name = "Denied", ResourceType = typeof(LocalizationEnum))]
        Denied = 149,
        [Display(Name = "Allowed", ResourceType = typeof(LocalizationEnum))]
        Allowed = 150,
        [Display(Name = "Accepted", ResourceType = typeof(LocalizationEnum))]
        Accepted = 151,
        [Display(Name = "DuplicateInvoice", ResourceType = typeof(LocalizationEnum))]
        Duplicate_invoice = 152,
        [Display(Name = "Expired", ResourceType = typeof(LocalizationEnum))]
        Expired = 153,
        [Display(Name = "Failed", ResourceType = typeof(LocalizationEnum))]
        Failed = 154,
        [Display(Name = "Unknown", ResourceType = typeof(LocalizationEnum))]
        Unknown = 155,
        [Display(Name = "Declined", ResourceType = typeof(LocalizationEnum))]
        Declined = 156,
        [Display(Name = "Approved", ResourceType = typeof(LocalizationEnum))]
        Approved = 157,
        [Display(Name = "Waiting", ResourceType = typeof(LocalizationEnum))]
        waiting = 158,
        [Display(Name = "TheStatusCannotBeApplied", ResourceType = typeof(LocalizationEnum))]
        The_status_cannot_be_applied = 159,
        [Display(Name = "ChangeIsProhibited", ResourceType = typeof(LocalizationEnum))]
        Change_is_prohibited = 160,
        [Display(Name = "DuplicatePhone", ResourceType = typeof(LocalizationEnum))]
        Duplicate_Phone = 161,
        [Display(Name = "LicenseUnitAlreadyIsFiscal", ResourceType = typeof(LocalizationEnum))]
        License_unit_already_is_fiscal = 162,
        [Display(Name = "InvalidID", ResourceType = typeof(LocalizationEnum))]
        Invalid_ID = 163,
        [Display(Name = "InvalidRSAKey", ResourceType = typeof(LocalizationEnum))]
        Invalid_RSAKey = 164,
        [Display(Name = "RecordNotExist", ResourceType = typeof(LocalizationEnum))]
        Record_not_exist = 165,
        [Display(Name = "BillNotExist", ResourceType = typeof(LocalizationEnum))]
        Bill_not_exist = 166,
        [Display(Name = "CardWithThatNumberExists", ResourceType = typeof(LocalizationEnum))]
        Card_with_that_number_exists = 167,
        [Display(Name = "BillAlreadyExists", ResourceType = typeof(LocalizationEnum))]
        Bill_already_exists = 168,
        [Display(Name = "PhoneListNotExist", ResourceType = typeof(LocalizationEnum))]
        Phone_list_not_exist = 169,
        [Display(Name = "ActiveDirectoryOrganizationalUnitDoesNotExist", ResourceType = typeof(LocalizationEnum))]
        Active_Directory_Organizational_unit_does_not_exist = 170,
        [Display(Name = "ActiveDirectoryOrganizationalUnitAlreadyExist", ResourceType = typeof(LocalizationEnum))]
        Active_Directory_Organizational_unit_already_exist = 171,
        [Display(Name = "TheAPIkeyDoesNotBelongToTheCompany", ResourceType = typeof(LocalizationEnum))]
        The_APIkey_does_not_belong_to_the_company = 172,
        [Display(Name = "ActiveDirectoryOrganizationalUnitNotExist", ResourceType = typeof(LocalizationEnum))]
        Active_Directory_Organizational_unit_not_exist = 173,
        [Display(Name = "ActiveDirectoryUserAlreadyExist", ResourceType = typeof(LocalizationEnum))]
        Active_Directory_User_already_exist = 174,
        [Display(Name = "InvalidFormatDatetime", ResourceType = typeof(LocalizationEnum))]
        Invalid_format_datetime = 175,
        [Display(Name = "InvalidCompanyIDNO", ResourceType = typeof(LocalizationEnum))]
        Invalid_Company_IDNO = 176,
        [Display(Name = "MailServiceNotActivated", ResourceType = typeof(LocalizationEnum))]
        Mail_service_not_activated = 177,
        [Display(Name = "AccessDenied", ResourceType = typeof(LocalizationEnum))]
        Access_denied = 178,
        [Display(Name = "FiscalDeviceNotExist", ResourceType = typeof(LocalizationEnum))] 
        Fiscal_Device_not_exist = 179,
        [Display(Name = "FiscalDeviceNotActivated", ResourceType = typeof(LocalizationEnum))] 
        Fiscal_Device_not_activated = 180,
        [Display(Name = "RecordAlreadyExist", ResourceType = typeof(LocalizationEnum))] 
        Record_already_exist = 181,
        [Display(Name = "ContractNotExist", ResourceType = typeof(LocalizationEnum))] 
        Contract_not_exist = 182,
        [Display(Name = "ApiKeyNotValid", ResourceType = typeof(LocalizationEnum))]
        ApiKey_not_valid = 183,
        [Display(Name = "MandatoryFieldIsNotSet", ResourceType = typeof(LocalizationEnum))]
        Mandatory_field_is_not_set = 184,
        [Display(Name = "FiscalDeviceIsActivated", ResourceType = typeof(LocalizationEnum))]
        Fiscal_Device_is_activated = 185,
        [Display(Name = "InvalidReceiptID", ResourceType = typeof(LocalizationEnum))]
        Invalid_receipt_ID = 186,
        [Display(Name = "ActivationCodeNotExist", ResourceType = typeof(LocalizationEnum))]
        Activation_code_not_exist = 187,
        [Display(Name = "SMSCampaignSetDraft", ResourceType = typeof(LocalizationEnum))]
        SMS_campaign_set_Draft = 188,
        [Display(Name = "TiketNotExist", ResourceType = typeof(LocalizationEnum))]
        Tiket_not_exist = 189,
        [Display(Name = "TicketReplyNotExist", ResourceType = typeof(LocalizationEnum))]
        Ticket_Reply_not_exist = 190,
        [Display(Name = "DatabaseServerNotExist", ResourceType = typeof(LocalizationEnum))]
        Database_server_not_exist = 192,
        [Display(Name = "ThePasswordDoesNotMeetThePasswordPolicyRequirements", ResourceType = typeof(LocalizationEnum))]
        The_password_does_not_meet_the_password_policy_requirements = 193,
        [Display(Name = "InvalidDigitalSignature", ResourceType = typeof(LocalizationEnum))]
        Invalid_digital_signature = 194,
        [Display(Name = "ParentRecordNotExist", ResourceType = typeof(LocalizationEnum))]
        Parent_record_not_exist = 195,
        [Display(Name = "DocumentationNotExist", ResourceType = typeof(LocalizationEnum))]
        Documentation_not_exist = 196,
        [Display(Name = "ServiceNotExist", ResourceType = typeof(LocalizationEnum))]
        Service_not_exist = 197,
        [Display(Name = "CannotAccessTheUserProfileDiskBecauseItIsBeingUsedByAnotherProcess", ResourceType = typeof(LocalizationEnum))]
        Cannot_access_the_user_profile_disk_because_it_is_being_used_by_another_process = 198,
        [Display(Name = "CannotAccessTheUserProfileDirectory", ResourceType = typeof(LocalizationEnum))]
        Cannot_access_the_user_profile_directory = 199,
        [Display(Name = "PhoneAlreadyUsedAnotherClient", ResourceType = typeof(LocalizationEnum))]
        Phone_already_used_another_client = 200,
        [Display(Name = "ClientNotExist", ResourceType = typeof(LocalizationEnum))]
        Client_not_exist = 201,
        [Display(Name = "InvalidValidationCode", ResourceType = typeof(LocalizationEnum))]
        Invalid_validation_code = 202,
        [Display(Name = "CardNotIsActive", ResourceType = typeof(LocalizationEnum))]
        Card_not_is_active = 203,
        [Display(Name = "VariableIsNullOrEmpty", ResourceType = typeof(LocalizationEnum))]
        Variable_is_null_or_empty = 204,
        [Display(Name = "SMSServiceNotActivated", ResourceType = typeof(LocalizationEnum))]
        SMS_service_not_activated = 205,
        [Display(Name = "NotSetPhoneOrEmail", ResourceType = typeof(LocalizationEnum))]
        Not_set_phone_or_email = 206,
        [Display(Name = "InsufficientFundsOnClientAccount", ResourceType = typeof(LocalizationEnum))]
        Insufficient_funds_on_client_account = 207,
        [Display(Name = "TheClientCardHasNoOwnAccount", ResourceType = typeof(LocalizationEnum))]
        The_client_card_has_no_own_account = 208,
        [Display(Name = "RecordWasUsed", ResourceType = typeof(LocalizationEnum))]
        Record_was_used = 209,
        [Display(Name = "InvalidReceiptDate", ResourceType = typeof(LocalizationEnum))]
        Invalid_receipt_date = 210,
        [Display(Name = "ActiveDirectoryNotResponse", ResourceType = typeof(LocalizationEnum))]
        Active_Directory_not_response = 211,
        [Display(Name = "RecordNotDisabled", ResourceType = typeof(LocalizationEnum))]
        Record_not_Disabled = 212,
        [Display(Name = "FunctionalityIsDisabled", ResourceType = typeof(LocalizationEnum))]
        Functionality_is_disabled = 213,
        [Display(Name = "InvalidWalletID", ResourceType = typeof(LocalizationEnum))]
        Invalid_Wallet_ID = 214,
        [Display(Name = "ConstraintViolationException", ResourceType = typeof(LocalizationEnum))]
        Constraint_violation_exception = 215,
        [Display(Name = "CompanyDisabled", ResourceType = typeof(LocalizationEnum))]
        Company_disabled = 216,
        [Display(Name = "CompanyAliasIsNotCorrect", ResourceType = typeof(LocalizationEnum))]
        Company_alias_is_not_correct = 217,
        [Display(Name = "ServiceCurrentlySuspended", ResourceType = typeof(LocalizationEnum))]
        Service_currently_suspended = 218,
        [Display(Name = "ClientDisabled", ResourceType = typeof(LocalizationEnum))]
        Client_disabled = 219,
        [Display(Name = "AccountDisabled", ResourceType = typeof(LocalizationEnum))]
        Account_disabled = 220,
        [Display(Name = "BankNotExist", ResourceType = typeof(LocalizationEnum))]
        Bank_not_exist = 221,
        [Display(Name = "BarcodeNotExist", ResourceType = typeof(LocalizationEnum))]
        Barcode_not_exist = 222,
        [Display(Name = "POSDisabled", ResourceType = typeof(LocalizationEnum))]
        POS_Disabled = 223,
        [Display(Name = "PointOfSalesNotExist", ResourceType = typeof(LocalizationEnum))]
        PointOfSales_not_exist = 224,
        [Display(Name = "PointOfSalesSettingsNotExist", ResourceType = typeof(LocalizationEnum))]
        PointOfSalesSettings_not_exist = 225,
        [Display(Name = "InvalidQR", ResourceType = typeof(LocalizationEnum))]
        Invalid_QR = 226,
        [Display(Name = "NotSetIDFiscalMemory", ResourceType = typeof(LocalizationEnum))]
        Not_set_ID_fiscal_memory = 227,
        [Display(Name = "FiscalMemoryNotActivated", ResourceType = typeof(LocalizationEnum))]
        Fiscal_memory_not_activated = 228,
        [Display(Name = "NotSetIDSDMemory", ResourceType = typeof(LocalizationEnum))]
        Not_set_ID_SD_memory = 229,
        [Display(Name = "FiscalMemoryWrongID", ResourceType = typeof(LocalizationEnum))]
        Fiscal_memory_wrong_ID = 230,
        [Display(Name = "FiscalMemoryBelongsToOtherDevice", ResourceType = typeof(LocalizationEnum))]
        Fiscal_memory_belongs_to_other_device = 231,
        [Display(Name = "FiscalDeviceisErased", ResourceType = typeof(LocalizationEnum))]
        Fiscal_Device_is_Erased = 235,
        [Display(Name = "InvoiceIsPaid", ResourceType = typeof(LocalizationEnum))]
        Invoice_is_Paid = 236,
        [Display(Name = "InvoiceIsCanceled", ResourceType = typeof(LocalizationEnum))]
        Invoice_is_Canceled = 237,
        [Display(Name = "NotSetPrinterTemplate", ResourceType = typeof(LocalizationEnum))]
        Not_set_PrinterTemplate = 238,
        [Display(Name = "ErrorConnectionDatabase", ResourceType = typeof(LocalizationEnum))]
        Error_Connection_Database = 239,
        [Display(Name = "InvalidActivationCode", ResourceType = typeof(LocalizationEnum))]
        Invalid_activation_code = 240,
    }
}
