using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TCM.Web.Business.Domain
{

    //[JsonConverter(typeof(StringEnumConverter))]
    //public enum eFrequencyCode
    //{
    //    YEAR,
    //    SEMI,
    //    QUTR,
    //    MNTH,
    //    WEEK,
    //    DAIL,
    //    CLOS,
    //    TOMN,
    //    TOWK,
    //    TWMN
    //}

    //[JsonConverter(typeof(StringEnumConverter))]
    //public enum eFundType
    //{
    //    EquityFund_Listed,
    //    EquityFund_NotListed,
    //    InterestRateFund_Listed,
    //    InterestRateFund_NotListed,
    //    MixFund_Listed,
    //    MixFund_NotListed
    //}



    [JsonConverter(typeof(StringEnumConverter))]
    public enum eDistributionPolicyCode
    {
        DISTRIBUTION,
        ACCUMULATION
    }
    //[JsonConverter(typeof(StringEnumConverter))]
    //public enum eDividendPolicyCode
    //{
    //    UNIT,
    //    CASH
    //}

    //[JsonConverter(typeof(StringEnumConverter))]
    //public enum eEUSDCode
    //{
    //    EUSI,
    //    EUSO,
    //    VARI
    //}

    //[JsonConverter(typeof(StringEnumConverter))]
    //public enum eTransferAllowedCode
    //{
    //    TRAL,
    //    TRNA,
    //    RFOD
    //}

    [JsonConverter(typeof(StringEnumConverter))]
    public enum eOrderLimitation
    {
        NOTALLOWED,
        AMOUNT,
        UNIT,
        BOTH
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum eSettlementType
    {
        ACTUAL,
        CONTRACTUAL
    }
}
