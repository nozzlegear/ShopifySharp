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

public class ShopifyPaymentsAddressBasicQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsAddressBasic>("shopifyPaymentsAddressBasic")
{
    public ShopifyPaymentsAddressBasicQueryBuilder AddFieldAddressLine1()
    {
        AddField("addressLine1");
        return this;
    }

    public ShopifyPaymentsAddressBasicQueryBuilder AddFieldAddressLine2()
    {
        AddField("addressLine2");
        return this;
    }

    public ShopifyPaymentsAddressBasicQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public ShopifyPaymentsAddressBasicQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public ShopifyPaymentsAddressBasicQueryBuilder AddFieldPostalCode()
    {
        AddField("postalCode");
        return this;
    }

    public ShopifyPaymentsAddressBasicQueryBuilder AddFieldZone()
    {
        AddField("zone");
        return this;
    }
}