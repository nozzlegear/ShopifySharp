#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

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