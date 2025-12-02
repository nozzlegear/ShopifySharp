#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class TenderTransactionCreditCardDetailsQueryBuilder() : GraphQueryBuilder<TenderTransactionCreditCardDetails>("tenderTransactionCreditCardDetails")
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