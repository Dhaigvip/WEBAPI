using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCM.Web.API.Core.Domain;

namespace TCM.Web.Business
{
    public static class DomainEntityProxyMapper
    {
        public static void RegisterDomainEntityProxyMapping(IMapperConfigurationExpression config)
        {
            #region Order
            config.CreateMap<Domain.OrderRepository, ProxyXFMOrder.OrderRepository>().ReverseMap();
            config.CreateMap<ProxyXFMOrder.Error, Error>().ReverseMap();

            config.CreateMap<ProxyXFMOrder.OrderRow, Domain.OrderRow>()
                .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.Identity.OrderId.ToString() : o.ExtPosReference)).ReverseMap();

            #endregion Order
            #region Aggregated Order
            //Aggregated Orders
            config.CreateMap<Domain.AggregatedOrderRepository, ProxyXFMAggregatedOrder.AggregatedOrderRepository>().ReverseMap();
            config.CreateMap<ProxyXFMAggregatedOrder.Error, Error>().ReverseMap();


            config.CreateMap<ProxyXFMAggregatedOrder.AggregatedOrderRow, Domain.AggregatedOrderRow>()
                           .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.Identity.AggregatedOrderId.ToString() : o.ExtPosReference)).ReverseMap();

            //Update
            config.CreateMap<ProxyXFMAggregatedOrder.AggregatedOrderUpdateSet, Domain.AggregatedOrderUpdateSet>().ReverseMap();

            config.CreateMap<Domain.AggregatedOrderUpdate, ProxyXFMAggregatedOrder.AggregatedOrderUpdate>().ReverseMap();
            config.CreateMap<ProxyXFMAggregatedOrder.AggregatedOrderUpdateResult, Domain.AggregatedOrderUpdateResult>()
                .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.AggregatedOrderId.ToString() : o.ExtPosReference)).ReverseMap();

            //Delete
            config.CreateMap<ProxyXFMAggregatedOrder.AggregatedOrderDeleteSet, Domain.AggregatedOrder.AggregatedOrderDeleteSet>().ReverseMap();
            config.CreateMap<Domain.AggregatedOrder.AggregatedOrderDelete, ProxyXFMAggregatedOrder.AggregatedOrderDelete>().ReverseMap();

            #endregion Aggregated Order
            #region Fund
            config.CreateMap<Domain.FundRepository, ProxyXFMFund.FundRepository>().ReverseMap();

            config.CreateMap<Domain.Fund.FundInfo, ProxyXFMFund.FundInfo>()
              .ForMember(dest => dest.RedemptionCutOffTime,
                 src => src.MapFrom(o => (o.RedemptionCutOffTime != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.RedemptionCutOffTime.Trim()).ToString("HH:mm:ss") : null))

                 .ForMember(dest => dest.SubscriptionCutOffTime,
                 src => src.MapFrom(o => (o.SubscriptionCutOffTime != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.SubscriptionCutOffTime.Trim()).ToString("HH:mm:ss") : null))

                 .ForMember(dest => dest.RedemptionCutOffTimeHalfDay,
                 src => src.MapFrom(o => (o.RedemptionCutOffTimeHalfDay != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.RedemptionCutOffTimeHalfDay.Trim()).ToString("HH:mm:ss") : null))
                      .ForMember(dest => dest.RedemptionCutOffTimeHalfDay,

                 src => src.MapFrom(o => (o.SubscriptionCutOffTimeHalfDay != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.SubscriptionCutOffTimeHalfDay.Trim()).ToString("HH:mm:ss") : null))

                 .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.Identity.FundId.ToString() : o.ExtPosReference));
            config.CreateMap<Error, ProxyXFMFund.Error>();


            config.CreateMap<ProxyXFMFund.FundInfo, Domain.Fund.FundInfo>()
                .ForMember(dest => dest.ExtPosReference,
               src => src.MapFrom(o => o.Identity.FundId.ToString()))
                .ForMember(dest => dest.RedemptionCutOffTime,
                 src => src.MapFrom(o => (o.RedemptionCutOffTime != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.RedemptionCutOffTime.Trim()).ToString("HH:mm:ss") : null))

                 .ForMember(dest => dest.SubscriptionCutOffTime,
                 src => src.MapFrom(o => (o.SubscriptionCutOffTime != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.SubscriptionCutOffTime.Trim()).ToString("HH:mm:ss") : null))

                 .ForMember(dest => dest.RedemptionCutOffTimeHalfDay,
                 src => src.MapFrom(o => (o.RedemptionCutOffTimeHalfDay != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.RedemptionCutOffTimeHalfDay.Trim()).ToString("HH:mm:ss") : null))
                      .ForMember(dest => dest.RedemptionCutOffTimeHalfDay,

                 src => src.MapFrom(o => (o.SubscriptionCutOffTimeHalfDay != null) ? Convert.ToDateTime(DateTime.MinValue.ToShortDateString() + " " + o.SubscriptionCutOffTimeHalfDay.Trim()).ToString("HH:mm:ss") : null));

            config.CreateMap<ProxyXFMFund.Error, Error>();


            //Overview

            config.CreateMap<Domain.Fund.FundOverviewRepository, ProxyXFMFund.FundOverviewRepository>().ReverseMap();
            config.CreateMap<ProxyXFMFund.FundOverview, Domain.Fund.FundOverview>()
              .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.Identity.FundId.ToString() : o.ExtPosReference)).ReverseMap();


            //Fund Save
            config.CreateMap<ProxyXFMFund.FundSaveSet, Domain.Fund.FundSaveSet>().ReverseMap();
            config.CreateMap<ProxyXFMFund.FundSaveResult, Domain.Fund.FundSaveResult>().ReverseMap();
            #endregion Fund
            #region Organization
            config.CreateMap<Domain.OrganizationRepository, ProxyXFMOrganization.OrganizationRepository>().ReverseMap();

            config.CreateMap<Error, ProxyXFMOrganization.Error>().ReverseMap();

            config.CreateMap<ProxyXFMOrganization.OrganizationInfo, Domain.Organisation.OrganizationInfo>()
                      .ForMember(dest => dest.ExtPosReference,
               src => src.MapFrom(o => o.Identity.OrganizationId.ToString())).ReverseMap();

            //Save

            config.CreateMap<ProxyXFMOrganization.OrganizationSaveSet, Domain.Organisation.OrganizationSaveSet>().ReverseMap();
            config.CreateMap<ProxyXFMOrganization.OrganizationSaveResult, Domain.Organisation.OrganizationSaveResult>().ReverseMap();

            #endregion Organization
            #region FX Order

            config.CreateMap<Domain.FxOrderRepository, ProxyXFMPricing.FxOrderRepository>().ReverseMap();
            config.CreateMap<ProxyXFMPricing.Error, Error>().ReverseMap();

            config.CreateMap<ProxyXFMPricing.FxOrder, Domain.FxOrder>()
                       .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.Identity.FxOrderId.ToString() : o.ExtPosReference)).ReverseMap();



            //Update
            config.CreateMap<ProxyXFMPricing.FxOrderUpdateSet, Domain.FxOrderUpdateSet>().ReverseMap();
            config.CreateMap<Domain.FxOrderUpdates, ProxyXFMPricing.FxOrderUpdates>().ReverseMap();
            config.CreateMap<ProxyXFMPricing.FxOrderUpdateResult, Domain.FxOrderUpdateResult>().ReverseMap();


            #endregion
            #region NAV

            config.CreateMap<Domain.FundPriceRepository, ProxyXFMPricing.FundPriceRepository>().ReverseMap();


            config.CreateMap<ProxyXFMPricing.Error, Error>().ReverseMap();

            config.CreateMap<ProxyXFMPricing.FundPrice, Domain.FundPrice>()
                        .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.FundPriceId.ToString() : o.ExtPosReference)).ReverseMap();


            //Update - TO DO 

            config.CreateMap<ProxyXFMPricing.FundPriceSaveSet, Domain.FundPriceSaveSet>().ReverseMap();
            config.CreateMap<Domain.FundPriceSaveInput, ProxyXFMPricing.FundPriceSaveInput>();
            config.CreateMap<ProxyXFMPricing.FundPriceSaveResult, Domain.FundPriceSaveResult>().ReverseMap();


            #endregion
            #region Account
            config.CreateMap<Domain.AccountRepository, ProxyXFMAccount.AccountRepository>().ReverseMap();
            config.CreateMap<Domain.Account.BalanceOverviewRepository, ProxyXFMAccount.BalanceOverviewRepository>().ReverseMap();


            config.CreateMap<ProxyXFMAccount.AccountMultiple, Domain.AccountMultiple>()
                       .ForMember(dest => dest.ExtPosReference,
                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.Identity.AccountId.ToString() : o.ExtPosReference)).ReverseMap();

            config.CreateMap<ProxyXFMAccount.BalanceOverview, Domain.Account.BalanceOverview>().ReverseMap();
            config.CreateMap<Error, ProxyXFMAccount.Error>().ReverseMap();

            //Update
            config.CreateMap<ProxyXFMAccount.ExternalAccount, Domain.ExternalAccount>().ReverseMap();

            //external Account

            config.CreateMap<Domain.Account.ExternalAccountRepository, ProxyXFMAccount.ExternalAccountRepository>().ReverseMap();

            #endregion Account
            #region Payment
            config.CreateMap<Domain.PaymentInformationRepository, ProxyXFMPayment.PaymentInformationRepository>().ReverseMap();
            config.CreateMap<Domain.PaymentInformation, ProxyXFMPayment.PaymentInformation>().ReverseMap();
            config.CreateMap<Domain.PaymentInformationDetails, ProxyXFMPayment.PaymentInformationDetails>()
            .ForMember(dest => dest.ExtPosReference,
               src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ? o.AccountNumber.ToString().Substring(Math.Max(0, o.AccountNumber.ToString().Length - 19)) : o.ExtPosReference)).ReverseMap();
            config.CreateMap<ProxyXFMPayment.Error, Error>().ReverseMap();

            //Update
            #endregion Payment
            #region UserSettings
            config.CreateMap<Domain.UserSettings.PersisterDTO, ProxyXFMUserSettings.Persister>().ReverseMap();

            config.CreateMap<Error, ProxyXFMUserSettings.Error>().ReverseMap();

            #endregion UserSettings
            #region Booking
            config.CreateMap<Domain.Booking.BookingOverviewRepository, ProxyBooking.BookingOverviewRepository>().ReverseMap();
            config.CreateMap<Domain.Booking.BookingOverview, ProxyBooking.BookingOverview>().ReverseMap();
            config.CreateMap<Error, ProxyBooking.Error>().ReverseMap();
            #endregion
            #region NordeaLuxHolder
            //config.CreateMap<Domain.Holder.HolderRepository, ProxyNluxHolder.HolderRepository>().ReverseMap();
            //config.CreateMap<ProxyNluxHolder.Holder, Domain.Holder.Holder>().ReverseMap();
            //config.CreateMap<ProxyNluxHolder.BeneficialOwner, Domain.Holder.BeneficialOwner>()
            //     .ForMember(dest => dest.ExtPosReference,
            //                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ?
            //                o.BeneficialOwnerId.ToString() : o.ExtPosReference));
            //           //.ForMember(dest => dest.BirthDay, src => src.MapFrom(o => (string.IsNullOrEmpty(o.BirthDay)) ? null : DateTime.Parse(o.BirthDay).ToString("d")));
            ////.ReverseMap();

            //config.CreateMap<Domain.Holder.BeneficialOwner, ProxyNluxHolder.BeneficialOwner>()
            //     .ForMember(dest => dest.ExtPosReference,
            //                src => src.MapFrom(o => (string.IsNullOrEmpty(o.ExtPosReference)) ?
            //                o.BeneficialOwnerId.ToString() : o.ExtPosReference));
            //           //.ForMember(dest => dest.BirthDay, src => src.MapFrom(o => (string.IsNullOrEmpty(o.BirthDay)) ? null : DateTime.Parse(o.BirthDay).ToString("d")));

            //config.CreateMap<Domain.Error, ProxyNluxHolder.Error>().ReverseMap();

            #endregion NordeaLuxHolder
        }
    }
}
