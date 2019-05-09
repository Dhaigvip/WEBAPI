//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TCM.Web.Business.Domain.NLuxPayment
//{

//    public partial class Branch
//    {

//        public TCM.Web.Business.ProxyNLuxPayment.BranchIdentity Identity { get; set; }


//        public string BranchIdentifier { get; set; }


//        public System.Nullable<long> BICId { get; set; }


//        public System.Nullable<long> BankId { get; set; }


//        public System.Nullable<long> NewBranchId { get; set; }


//        public string ObjectVersion { get; set; }


//        public string BICName { get; set; }


//        public string BIC { get; set; }


//        public string BankName { get; set; }


//        public string NewBranchShortName { get; set; }


//        public string NewBranchName { get; set; }


//        public System.Nullable<System.DateTime> EndDate { get; set; }


//        public System.Collections.Generic.List<TCM.Web.Business.ProxyNLuxPayment.Address> AddressDTOList { get; set; }


//    }

//    public partial class HolderCashAccountRepository 
//    {        
//        public TCM.Web.Business.ProxyNLuxPayment.CriteriaOptions Options{get;set;}

        
//        public string CriteriaType{get;set;}

        
//        public System.Nullable<long> TotalRecords{get;set;}

        
//        public System.Collections.Generic.List<HolderCashAccount> HolderCashAccountList{get;set;}

        
//        public System.Collections.Generic.List<TCM.Web.Business.ProxyNLuxPayment.GeneralCriterion> SearchCriteria{get;set;}

        
//        public System.Collections.Generic.List<TCM.Web.Business.ProxyNLuxPayment.SimpleCriterion> ListCriteria{get;set;}

        
//        public System.Collections.Generic.List<TCM.Web.Business.ProxyNLuxPayment.PaymentMethod> IdentityCriteria{get;set;}

        
//        public System.Collections.Generic.List<TCM.Web.Business.ProxyNLuxPayment.OrganizationIdentity> CustomerAdministratorCriteria{get;set;}
        
//    }

    
//    public partial class HolderCashAccount
//    {

//        public TCM.Web.Business.ProxyNLuxPayment.HolderCashAccountIdentity Identity { get; set; }


//        public TCM.Web.Business.ProxyNLuxPayment.OrganizationIdentity CustomerAdministrator { get; set; }


//        public HolderPaymentInstructionTemplate HolderPaymentInstruction { get; set; }


//        public TCM.Web.Business.ProxyNLuxPayment.BranchIdentity Branch { get; set; }


//        public TCM.Web.Business.ProxyNLuxPayment.ExternalHolderCashAccountOwnerIdentity ExternalOwner { get; set; }


//        public TCM.Web.Business.ProxyNLuxPayment.BranchCashAccountIdentity CorrespondentBranchCashAccount { get; set; }


//        public HolderPaymentInstructionTemplate SystemPaymentInstruction { get; set; }


//        public string ObjectVersion { get; set; }


//        public System.Nullable<byte> CashAccountNumberTypeId { get; set; }


//        public string ExternalHolderCashAccountId { get; set; }


//        public System.Collections.Generic.List<TCM.Web.Business.ProxyNLuxPayment.TransactionType> TransactionTypeList { get; set; }


//        public System.Collections.Generic.List<HolderPaymentInstructionTemplateDetail> HolderPaymentInstructionTemplateDetailList { get; set; }


//    }

//    public partial class HolderPaymentInstructionTemplateDetail
//    {



//        public TCM.Web.Business.ProxyNLuxPayment.PaymentMethodMessageEntity PaymentMethodMessageEntity { get; set; }


//        public TCM.Web.Business.ProxyNLuxPayment.BranchIdentity Branch { get; set; }


//        public string CorrespondantBranchCashAccountId { get; set; }


//        public string ExtPosReference { get; set; }

//    }


//    public partial class HolderPaymentInstructionTemplate
//    {

//        public System.Nullable<long> HolderPaymentInstructionTemplateId { get; set; }


//        public string HolderCashAccountTypeId { get; set; }


//        public string HolderCashAccountTypeName { get; set; }


//        public string StartDay { get; set; }


//        public string EndDay { get; set; }


//        public System.Nullable<long> HolderId { get; set; }


//        public System.Nullable<long> SystemPaymentInstructionTemplateId { get; set; }


//        public string SystemCashAccountId { get; set; }


//        public string SystemCashAccountCurrencyId { get; set; }


//        public string SystemCashAccountTypeId { get; set; }


//        public string PaymentReference { get; set; }


//        public string PaymentReference2 { get; set; }


//        public string PaymentReference3 { get; set; }


//        public string PaymentInstructionTemplateCode { get; set; }


//        public System.Nullable<int> ValueDayLag { get; set; }


//        public string PaymentInstructionMessageTypeId { get; set; }


//        public System.Nullable<bool> ApprovePayments { get; set; }


//        public System.Nullable<bool> AggregatePayments { get; set; }


//        public System.Nullable<bool> IsApproved { get; set; }


//        public System.Nullable<System.DateTime> ApprovedDate { get; set; }


//        public string ApprovedByRegUser { get; set; }


//        public System.Nullable<System.DateTime> RegisteredDate { get; set; }


//        public string RegisteredByRegUser { get; set; }


//        public string ClientRowVersion { get; set; }


//        public System.Nullable<int> ErrorNumber { get; set; }


//        public string ErrorText { get; set; }


//        public string ExtPosReference { get; set; }

//    }
//}
