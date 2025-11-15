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

public class CustomerAccountsV2QueryBuilder() : GraphQueryBuilder<CustomerAccountsV2>("query customerAccountsV2")
{
    public CustomerAccountsV2QueryBuilder AddFieldCustomerAccountsVersion()
    {
        AddField("customerAccountsVersion");
        return this;
    }

    public CustomerAccountsV2QueryBuilder AddFieldLoginLinksVisibleOnStorefrontAndCheckout()
    {
        AddField("loginLinksVisibleOnStorefrontAndCheckout");
        return this;
    }

    public CustomerAccountsV2QueryBuilder AddFieldLoginRequiredAtCheckout()
    {
        AddField("loginRequiredAtCheckout");
        return this;
    }

    public CustomerAccountsV2QueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}