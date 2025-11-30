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

public class MetafieldAccessQueryBuilder() : GraphQueryBuilder<MetafieldAccess>("query metafieldAccess")
{
    public MetafieldAccessQueryBuilder AddFieldAdmin()
    {
        AddField("admin");
        return this;
    }

    public MetafieldAccessQueryBuilder AddFieldCustomerAccount()
    {
        AddField("customerAccount");
        return this;
    }

    public MetafieldAccessQueryBuilder AddFieldStorefront()
    {
        AddField("storefront");
        return this;
    }
}