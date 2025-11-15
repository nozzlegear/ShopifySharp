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
/// Payment details related to a transaction.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<PaymentDetails>))]
public record PaymentDetails : GraphQLObject<PaymentDetails>, IGraphQLUnionType
{
    public CardPaymentDetails? AsCardPaymentDetails() => this is PaymentDetailsCardPaymentDetails wrapper ? wrapper.Value : null;
    public LocalPaymentMethodsPaymentDetails? AsLocalPaymentMethodsPaymentDetails() => this is PaymentDetailsLocalPaymentMethodsPaymentDetails wrapper ? wrapper.Value : null;
    public PaypalWalletPaymentDetails? AsPaypalWalletPaymentDetails() => this is PaymentDetailsPaypalWalletPaymentDetails wrapper ? wrapper.Value : null;
    public ShopPayInstallmentsPaymentDetails? AsShopPayInstallmentsPaymentDetails() => this is PaymentDetailsShopPayInstallmentsPaymentDetails wrapper ? wrapper.Value : null;
}