#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Some of the payment methods used in Shopify.
/// </summary>
public enum PaymentMethods
{
    VISA,
    MASTERCARD,
    DISCOVER,
    AMERICAN_EXPRESS,
    DINERS_CLUB,
    JCB,
    UNIONPAY,
    ELO,
    DANKORT,
    MAESTRO,
    FORBRUGSFORENINGEN,
    PAYPAL,
    BOGUS,
    BITCOIN,
    LITECOIN,
    DOGECOIN,
    INTERAC,
    EFTPOS,
    CARTES_BANCAIRES,
    BANCONTACT,
}