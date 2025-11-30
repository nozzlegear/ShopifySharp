#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TenderTransactionCreditCardDetailsQueryBuilder() : GraphQueryBuilder<TenderTransactionCreditCardDetails>("query tenderTransactionCreditCardDetails")
{
    public TenderTransactionCreditCardDetailsQueryBuilder AddFieldCreditCardCompany()
    {
        AddField("creditCardCompany");
        return this;
    }

    public TenderTransactionCreditCardDetailsQueryBuilder AddFieldCreditCardNumber()
    {
        AddField("creditCardNumber");
        return this;
    }
}