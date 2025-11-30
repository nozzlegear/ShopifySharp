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

public class PriceRuleCustomerSelectionQueryBuilder() : GraphQueryBuilder<PriceRuleCustomerSelection>("query priceRuleCustomerSelection")
{
    public PriceRuleCustomerSelectionQueryBuilder AddFieldCustomers()
    {
        AddField("customers");
        return this;
    }

    public PriceRuleCustomerSelectionQueryBuilder AddFieldForAllCustomers()
    {
        AddField("forAllCustomers");
        return this;
    }

    public PriceRuleCustomerSelectionQueryBuilder AddFieldSegments()
    {
        AddField("segments");
        return this;
    }
}